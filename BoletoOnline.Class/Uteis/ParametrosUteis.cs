using System.Configuration;

namespace BoletoOnline.Class.Uteis
{
    public class ParametrosUteis
    {
        public static string RetornaImpressaoDigitalCertificado()
        {
#if DEBUG
            {
                return ConfigurationManager.AppSettings["ImpressaoDigitalCertificadoHomologacao"];

            }
#endif
            return ConfigurationManager.AppSettings["ImpressaoDigitalCertificadoProducao"];
        }

        public static string RetornaUrlEnvio()
        {
#if DEBUG
            {
                return "https://cobranca.bradesconetempresa.b.br/ibpjregistrotitulows/registrotitulohomologacao";

            }
#endif
            return "https://cobranca.bradesconetempresa.b.br/ibpjregistrotitulows/registrotitulo";
        }
    }
}
