using System;
using System.Runtime.Serialization;

namespace BoletoOnline.Class.Objetos
{
    [DataContract]
    public class EnvioRemessaCobrancaBradescoJson
    {
        [DataMember]
        public string nuCPFCNPJ { get; set; }

        [DataMember]
        public string filialCPFCNPJ { get; set; }

        [DataMember]
        public string ctrlCPFCNPJ { get; set; }

        [DataMember]
        public string cdTipoAcesso { get; set; }

        [DataMember]
        public string clubBanco { get; set; }

        [DataMember]
        public string cdTipoContrato { get; set; }

        [DataMember]
        public string nuSequenciaContrato { get; set; }

        [DataMember]
        public string idProduto { get; set; }

        [DataMember]
        public string nuNegociacao { get; set; }

        [DataMember]
        public string cdBanco { get; set; }

        [DataMember]
        public string eNuSequenciaContrato { get; set; }

        [DataMember]
        public string tpRegistro { get; set; }

        [DataMember]
        public string cdProduto { get; set; }

        [DataMember]
        public string nuTitulo { get; set; }

        [DataMember]
        public string nuCliente { get; set; }

        [DataMember]
        public string dtEmissaoTitulo { get; set; }

        [DataMember]
        public string dtVencimentoTitulo { get; set; }

        [DataMember]
        public string tpVencimento { get; set; }

        [DataMember]
        public string vlNominalTitulo { get; set; }

        [DataMember]
        public string cdEspecieTitulo { get; set; }

        [DataMember]
        public string tpProtestoAutomaticoNegativacao { get; set; }

        [DataMember]
        public string prazoProtestoAutomaticoNegativacao { get; set; }

        [DataMember]
        public string controleParticipante { get; set; }

        [DataMember]
        public string cdPagamentoParcial { get; set; }

        [DataMember]
        public string qtdePagamentoParcial { get; set; }

        [DataMember]
        public string percentualJuros { get; set; }

        [DataMember]
        public string vlJuros { get; set; }

        [DataMember]
        public string qtdeDiasJuros { get; set; }

        [DataMember]
        public string percentualMulta { get; set; }

        [DataMember]
        public string vlMulta { get; set; }

        [DataMember]
        public string qtdeDiasMulta { get; set; }

        [DataMember]
        public string percentualDesconto1 { get; set; }

        [DataMember]
        public string vlDesconto1 { get; set; }

        [DataMember]
        public string dataLimiteDesconto1 { get; set; }

        [DataMember]
        public string percentualDesconto2 { get; set; }

        [DataMember]
        public string vlDesconto2 { get; set; }

        [DataMember]
        public string dataLimiteDesconto2 { get; set; }

        [DataMember]
        public string percentualDesconto3 { get; set; }

        [DataMember]
        public string vlDesconto3 { get; set; }

        [DataMember]
        public string dataLimiteDesconto3 { get; set; }

        [DataMember]
        public string prazoBonificacao { get; set; }

        [DataMember]
        public string percentualBonificacao { get; set; }

        [DataMember]
        public string vlBonificacao { get; set; }

        [DataMember]
        public string dtLimiteBonificacao { get; set; }

        [DataMember]
        public string vlAbatimento { get; set; }

        [DataMember]
        public string vlIOF { get; set; }

        [DataMember]
        public string nomePagador { get; set; }

        [DataMember]
        public string logradouroPagador { get; set; }

        [DataMember]
        public string nuLogradouroPagador { get; set; }

        [DataMember]
        public string complementoLogradouroPagador { get; set; }

        [DataMember]
        public string cepPagador { get; set; }

        [DataMember]
        public string complementoCepPagador { get; set; }

        [DataMember]
        public string bairroPagador { get; set; }

        [DataMember]
        public string municipioPagador { get; set; }

        [DataMember]
        public string ufPagador { get; set; }

        [DataMember]
        public string cdIndCpfcnpjPagador { get; set; }

        [DataMember]
        public string nuCpfcnpjPagador { get; set; }

        [DataMember]
        public string endEletronicoPagador { get; set; }
        [DataMember]
        public string nomeSacadorAvalista { get; set; }
        [DataMember]
        public string logradouroSacadorAvalista { get; set; }
        [DataMember]
        public string nuLogradouroSacadorAvalista { get; set; }
        [DataMember]
        public string complementoLogradouroSacadorAvalista { get; set; }
        [DataMember]
        public string cepSacadorAvalista { get; set; }
        [DataMember]
        public string complementoCepSacadorAvalista { get; set; }

        [DataMember]
        public string bairroSacadorAvalista { get; set; }
        [DataMember]
        public string municipioSacadorAvalista { get; set; }
        [DataMember]
        public string ufSacadorAvalista { get; set; }
        [DataMember]
        public string cdIndCpfcnpjSacadorAvalista { get; set; }
        [DataMember]
        public string nuCpfcnpjSacadorAvalista { get; set; }
        [DataMember]
        public string endEletronicoSacadorAvalista { get; set; }
    }
}
