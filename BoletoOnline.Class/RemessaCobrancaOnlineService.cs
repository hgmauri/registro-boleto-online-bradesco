using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;
using BoletoOnline.Class.Objetos;
using BoletoOnline.Class.Uteis;
using Newtonsoft.Json;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509.Store;

namespace BoletoOnline.Class
{
    public class RemessaCobrancaOnlineService
    {
        public void AssinarCriptografar(EnvioRemessaCobrancaBradescoJson model)
        {
            try
            {
                var utilClass = new MetodosUteis();
                var encoding = new UTF8Encoding();
                var generator = new CmsSignedDataGenerator();
                var signerInfoGeneratorBuilder = new SignerInfoGeneratorBuilder();
                IList certList = new ArrayList();

                var criticas = utilClass.Criticas(model);
                if (criticas.Any())
                {
                    return;
                }

                var data = utilClass.ConverterParaJsonAspasSimples(model);

                var privateCert = this.RetornaCertificado();

                //convertendo certificado para objeto que o bouncycastle conhece
                var bouncyCastleKey = DotNetUtilities.GetKeyPair(privateCert.PrivateKey).Private;
                var x5091 = new X509Certificate(privateCert.RawData);
                var x509CertBouncyCastle = DotNetUtilities.FromX509Certificate(x5091);

                generator.AddSignerInfoGenerator(signerInfoGeneratorBuilder.Build(new Asn1SignatureFactory("SHA256WithRSA", bouncyCastleKey), x509CertBouncyCastle));

                //criando certstore que o bouncycastle conhece
                certList.Add(x509CertBouncyCastle);

                var store509BouncyCastle = X509StoreFactory.Create("Certificate/Collection", new X509CollectionStoreParameters(certList));
                generator.AddCertificates(store509BouncyCastle);

                var messageBytes = encoding.GetBytes(data);
                var cmsdata = new CmsProcessableByteArray(messageBytes);

                //assina
                var signeddata = generator.Generate(cmsdata, true);
                var mensagemFinal = signeddata.GetEncoded();

                //converte para base64 que eh o formato que o serviço espera
                var mensagemConvertidaparaBase64 = Convert.ToBase64String(mensagemFinal);

                //chama serviço convertendo a string na base64 em bytes
                EnviaParaWebService(ParametrosUteis.RetornaUrlEnvio(), encoding.GetBytes(mensagemConvertidaparaBase64));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private X509Certificate2 RetornaCertificado()
        {
            var impressaDigitalCertificado = ParametrosUteis.RetornaImpressaoDigitalCertificado();

            var store = new X509Store(StoreLocation.LocalMachine);

            store.Open(OpenFlags.ReadOnly);

            var privateCert = store.Certificates.Cast<X509Certificate2>().FirstOrDefault(cert => cert.Thumbprint == impressaDigitalCertificado && cert.HasPrivateKey);

            if (privateCert == null)
                throw new Exception("Certificado não localizado.");
            if (privateCert.PrivateKey == null)
                throw new Exception("chave privada não localizada no certificado.");

            return privateCert;
        }

        private void EnviaParaWebService(string uri, byte[] sig)
        {
            //TLS 1.2
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

            var request = WebRequest.Create(uri);

            request.Method = "POST";
            request.ContentType = "application/pkcs7-signature";
            request.ContentLength = sig.Length;

            using (var requestStream = request.GetRequestStream())
            {
                requestStream.Write(sig, 0, sig.Length);
            }

            var response = request.GetResponse();

            using (var stream = response.GetResponseStream())
            {
                if (stream == null)
                {
                    throw new ApplicationException("erro ao obter resposta");
                }

                var reader = new StreamReader(stream);

                // resultado FINAL aqui
                var retorno = reader.ReadToEnd();

                var respostaAqui = JsonConvert.DeserializeObject<RetornoRemessaCobrancaBradescoJson>(XDocument.Parse(retorno).Root.Value);
            }
        }
    }
}
