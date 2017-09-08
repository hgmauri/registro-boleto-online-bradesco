using System.Runtime.Serialization;

namespace BoletoOnline.Class.Objetos
{
    public class RetornoRemessaCobrancaBradescoJson
    {
        [DataMember]
        public string cdErro { get; set; }

        [DataMember]
        public string msgErro { get; set; }

        [DataMember]
        public string idProduto { get; set; }

        [DataMember]
        public string negociação { get; set; }

        [DataMember]
        public string clubBanco { get; set; }

        [DataMember]
        public string tpContrato { get; set; }

        [DataMember]
        public string nuSequenciaContrato { get; set; }

        [DataMember]
        public string cdProduto { get; set; }

        [DataMember]
        public string nuTituloGerado { get; set; }

        [DataMember]
        public string agenciaCreditoBeneficiario { get; set; }

        [DataMember]
        public string contaCreditoBeneficiario { get; set; }

        [DataMember]
        public string digCreditoBeneficiario { get; set; }

        [DataMember]
        public string cdCipTitulo { get; set; }

        [DataMember]
        public string statusTitulo { get; set; }

        [DataMember]
        public string descStatusTitulo { get; set; }

        [DataMember]
        public string nomeBeneficiario { get; set; }

        [DataMember]
        public string logradouroBeneficiario { get; set; }

        [DataMember]
        public string nuLogradouroBeneficiario { get; set; }

        [DataMember]
        public string complementoLogradouroBeneficiario { get; set; }

        [DataMember]
        public string cepBeneficiario { get; set; }

        [DataMember]
        public string cepComplementoBeneficiario { get; set; }

        [DataMember]
        public string municipioBeneficiario { get; set; }

        [DataMember]
        public string ufBeneficiario { get; set; }

        [DataMember]
        public string razaoContaBeneficiario { get; set; }

        [DataMember]
        public string nomePagador { get; set; }

        [DataMember]
        public string cpfcnpjPagador { get; set; }

        [DataMember]
        public string enderecoPagador { get; set; }

        [DataMember]
        public string bairroPagador { get; set; }

        [DataMember]
        public string municipioPagador { get; set; }

        [DataMember]
        public string ufPagador { get; set; }

        [DataMember]
        public string cepPagador { get; set; }

        [DataMember]
        public string cepComplementoPagador { get; set; }

        [DataMember]
        public string endEletronicoPagador { get; set; }

        [DataMember]
        public string nomeSacadorAvalista { get; set; }

        [DataMember]
        public string cpfcnpjSacadorAvalista { get; set; }

        [DataMember]
        public string enderecoSacadorAvalista { get; set; }

        [DataMember]
        public string municipioSacadorAvalista { get; set; }

        [DataMember]
        public string ufSacadorAvalista { get; set; }

        [DataMember]
        public string cepSacadorAvalista { get; set; }

        [DataMember]
        public string cepComplementoSacadorAvalista { get; set; }

        [DataMember]
        public string numeroTitulo { get; set; }

        [DataMember]
        public string dtRegistro { get; set; }

        [DataMember]
        public string especieDocumentoTitulo { get; set; }

        [DataMember]
        public string descEspecie { get; set; }

        [DataMember]
        public string vlIOF { get; set; }

        [DataMember]
        public string dtEmissao { get; set; }

        [DataMember]
        public string dtVencimento { get; set; }

        [DataMember]
        public string vlTitulo { get; set; }

        [DataMember]
        public string vlAbatimento { get; set; }

        [DataMember]
        public string dtInstrucaoProtestoNegativação { get; set; }

        [DataMember]
        public string diasInstrucaoProtestoNegativação { get; set; }

        [DataMember]
        public string dtMulta { get; set; }

        [DataMember]
        public string vlMulta { get; set; }

        [DataMember]
        public string qtdeCasasDecimaisMulta { get; set; }

        [DataMember]
        public string cdValorMulta { get; set; }

        [DataMember]
        public string descCdMulta { get; set; }

        [DataMember]
        public string dtJuros { get; set; }

        [DataMember]
        public string vlJurosAoDia { get; set; }
        [DataMember]
        public string dtDesconto1Bonificacao { get; set; }
        [DataMember]
        public string vlDesconto1Bonificacao { get; set; }
        [DataMember]
        public string qtdeCasasDecimaisDesconto1Bonificacao { get; set; }
        [DataMember]
        public string cdValorDesconto1Bonificacao { get; set; }
        [DataMember]
        public string descCdDesconto1Bonificacao { get; set; }
        [DataMember]
        public string dtDesconto2 { get; set; }

        [DataMember]
        public string vlDesconto2 { get; set; }
        [DataMember]
        public string qtdeCasasDecimaisDesconto2 { get; set; }
        [DataMember]
        public string cdValorDesconto2 { get; set; }
        [DataMember]
        public string descCdDesconto2 { get; set; }
        [DataMember]
        public string dtDesconto3 { get; set; }
        [DataMember]
        public string vlDesconto3 { get; set; }
        [DataMember]
        public string qtdeCasasDecimaisDesconto3 { get; set; }
        [DataMember]
        public string cdValorDesconto3 { get; set; }
        [DataMember]
        public string descCdDesconto3 { get; set; }
        [DataMember]
        public string diasDispensaMulta { get; set; }
        [DataMember]
        public string diasDispensaJuros { get; set; }
        [DataMember]
        public string cdBarras { get; set; }
        [DataMember]
        public string linhaDigitavel { get; set; }
        [DataMember]
        public string cdAcessorioEscrituralEmpresa { get; set; }
        [DataMember]
        public string tpVencimento { get; set; }
        [DataMember]
        public string indInstrucaoProtesto { get; set; }
        [DataMember]
        public string tipoAbatimentoTitulo { get; set; }
        [DataMember]
        public string cdValorJuros { get; set; }
        [DataMember]
        public string tpDesconto1 { get; set; }
        [DataMember]
        public string tpDesconto2 { get; set; }
        [DataMember]
        public string tpDesconto3 { get; set; }
        [DataMember]
        public string nuControleParticipante { get; set; }
        [DataMember]
        public string diasJuros { get; set; }
        [DataMember]
        public string cdJuros { get; set; }
        [DataMember]
        public string vlJuros { get; set; }
        [DataMember]
        public string cpfcnpjBeneficiário { get; set; }
        [DataMember]
        public string vlTituloEmitidoBoleto { get; set; }
        [DataMember]
        public string dtVencimentoBoleto { get; set; }
        [DataMember]
        public string indTituloPertenceBaseTitulos { get; set; }
        [DataMember]
        public string dtLimitePagamentoBoleto { get; set; }
        [DataMember]
        public string cdIdentificacaoTituloDDACIP { get; set; }
        [DataMember]
        public string indPagamentoParcial { get; set; }
        [DataMember]
        public string qtdePagamentoParciais { get; set; }
    }
}
