using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BoletoOnline.Class.Objetos;
using Newtonsoft.Json;

namespace BoletoOnline.Class.Uteis
{
    public class MetodosUteis
    {
        public bool EhValido(EnvioRemessaCobrancaBradescoJson entidade)
        {
            return !Criticas(entidade).Any();
        }

        public IEnumerable<string> Criticas(EnvioRemessaCobrancaBradescoJson entidade)
        {
            //Campos Obrigatórios e condicionalmente obrigatórios
            if (EstaVazio(entidade.nuCpfcnpjPagador) || entidade.nuCpfcnpjPagador.Length > 9)
                yield return "Campo nuCpfcnpjPagador não pode ser vazio e precisa ter tamanho máximo de 9";

            if (EstaVazio(entidade.filialCPFCNPJ) || entidade.filialCPFCNPJ.Length > 4)
                yield return "Campo filialCPFCNPJ não pode ser vazio e precisa ter tamanho máximo de 4";

            if (EstaVazio(entidade.ctrlCPFCNPJ) || entidade.ctrlCPFCNPJ.Length > 2)
                yield return "Campo ctrlCPFCNPJ não pode ser vazio e precisa ter tamanho máximo de 2";

            if (EstaVazio(entidade.cdTipoAcesso) || entidade.cdTipoAcesso.Length > 1)
                yield return "Campo cdTipoAcesso não pode ser vazio e precisa ter tamanho máximo de 1";

            if (EstaVazio(entidade.idProduto) || entidade.idProduto.Length > 2)
                yield return "Campo idProduto não pode ser vazio e precisa ter tamanho máximo de 2";

            if (EstaVazio(entidade.nuNegociacao) || entidade.nuNegociacao.Length > 18)
                yield return "Campo nuNegociacao não pode ser vazio e precisa ter tamanho máximo de 18";

            if (EstaVazio(entidade.cdBanco) || entidade.cdBanco.Length > 3)
                yield return "Campo cdBanco não pode ser vazio e precisa ter tamanho máximo de 3";

            if (EstaVazio(entidade.tpRegistro) || entidade.tpRegistro.Length > 3)
                yield return "Campo tpRegistro não pode ser vazio e precisa ter tamanho máximo de 3";

            if (EstaVazio(entidade.nuCliente) || entidade.nuCliente.Length > 10)
                yield return "Campo nuCliente não pode ser vazio e precisa ter tamanho máximo de 10";

            if (EstaVazio(entidade.dtEmissaoTitulo) || entidade.dtEmissaoTitulo.Length > 10)
                yield return "Campo dtEmissaoTitulo não pode ser vazio e precisa ter tamanho máximo de 10";

            if (EstaVazio(entidade.dtVencimentoTitulo) || entidade.dtVencimentoTitulo.Length > 10)
                yield return "Campo dtVencimentoTitulo não pode ser vazio e precisa ter tamanho máximo de 10";

            if (EstaVazio(entidade.tpVencimento) || entidade.tpVencimento.Length > 1)
                yield return "Campo tpVencimento não pode ser vazio e precisa ter tamanho máximo de 1";

            if (EstaVazio(entidade.vlNominalTitulo) || entidade.vlNominalTitulo.Length > 17)
                yield return "Campo vlNominalTitulo não pode ser vazio e precisa ter tamanho máximo de 17";

            if (EstaVazio(entidade.cdEspecieTitulo) || entidade.cdEspecieTitulo.Length > 2)
                yield return "Campo cdEspecieTitulo não pode ser vazio e precisa ter tamanho máximo de 2";

            if (EstaVazio(entidade.cdEspecieTitulo) || entidade.cdEspecieTitulo.Length > 2)
                yield return "Campo cdEspecieTitulo não pode ser vazio e precisa ter tamanho máximo de 2";

            if (!EstaVazio(entidade.tpProtestoAutomaticoNegativacao))
            {
                if (EstaVazio(entidade.prazoProtestoAutomaticoNegativacao) || entidade.prazoProtestoAutomaticoNegativacao.Length > 2)
                    yield return "Campo prazoProtestoAutomaticoNegativacao não pode ser vazio e precisa ter tamanho máximo de 2, pois tpProtestoAutomaticoNegativacao não está vazio";
            }

            if (!(EstaVazio(entidade.vlDesconto1) || EstaVazio(entidade.percentualDesconto1)))
            {
                if (EstaVazio(entidade.dataLimiteDesconto1) || entidade.dataLimiteDesconto1.Length > 10)
                    yield return "Campo dataLimiteDesconto1 não pode ser vazio e precisa ter tamanho máximo de 10, pois vlDesconto1 ou percentualDesconto1 foi informado";
            }

            if (!(EstaVazio(entidade.vlDesconto2) || EstaVazio(entidade.percentualDesconto2)))
            {
                if (EstaVazio(entidade.dataLimiteDesconto2) || entidade.dataLimiteDesconto2.Length > 10)
                    yield return "Campo dataLimiteDesconto2 não pode ser vazio e precisa ter tamanho máximo de 10, pois vlDesconto2 ou percentualDesconto2 foi informado";
            }

            if (!(EstaVazio(entidade.vlDesconto3) || EstaVazio(entidade.percentualDesconto3)))
            {
                if (EstaVazio(entidade.dataLimiteDesconto3) || entidade.dataLimiteDesconto3.Length > 10)
                    yield return "Campo dataLimiteDesconto3 não pode ser vazio e precisa ter tamanho máximo de 10, pois vlDesconto3 ou percentualDesconto3 foi informado";
            }

            if (!(EstaVazio(entidade.percentualBonificacao) || EstaVazio(entidade.vlBonificacao)))
            {
                if (EstaVazio(entidade.prazoBonificacao) || entidade.prazoBonificacao.Length > 2)
                    yield return "Campo prazoBonificacao não pode ser vazio e precisa ter tamanho máximo de 2, pois percentualBonificacao ou vlBonificacao foi informado";

                if (EstaVazio(entidade.dtLimiteBonificacao) || entidade.dtLimiteBonificacao.Length > 10)
                    yield return "Campo dtLimiteBonificacao não pode ser vazio e precisa ter tamanho máximo de 10, pois percentualBonificacao ou vlBonificacao foi informado";
            }

            if (!(EstaVazio(entidade.cdPagamentoParcial) && entidade.cdPagamentoParcial == "S"))
            {
                if (EstaVazio(entidade.qtdePagamentoParcial) || entidade.qtdePagamentoParcial.Length > 3)
                    yield return "Campo qtdePagamentoParcial não pode ser vazio e precisa ter tamanho máximo de 3, pois cdPagamentoParcial foi informado";
            }

            //Somente para cobrança carteira de seguros (????)
            if (EstaVazio(entidade.vlIOF) || entidade.vlIOF.Length > 17)
                yield return "Campo vlIOF não pode ser vazio e precisa ter tamanho máximo de 17";

            if (EstaVazio(entidade.nomePagador) || entidade.nomePagador.Length > 70)
                yield return "Campo nomePagador não pode ser vazio e precisa ter tamanho máximo de 70";

            if (EstaVazio(entidade.logradouroPagador) || entidade.logradouroPagador.Length > 40)
                yield return "Campo logradouroPagador não pode ser vazio e precisa ter tamanho máximo de 40";

            if (EstaVazio(entidade.nuLogradouroPagador) || entidade.nuLogradouroPagador.Length > 10)
                yield return "Campo nuLogradouroPagador não pode ser vazio e precisa ter tamanho máximo de 10";

            if (EstaVazio(entidade.cepPagador) || entidade.cepPagador.Length > 5)
                yield return "Campo cepPagador não pode ser vazio e precisa ter tamanho máximo de 5";

            if (EstaVazio(entidade.complementoCepPagador) || entidade.complementoCepPagador.Length > 3)
                yield return "Campo complementoCepPagador não pode ser vazio e precisa ter tamanho máximo de 3";

            if (EstaVazio(entidade.bairroPagador) || entidade.bairroPagador.Length > 40)
                yield return "Campo bairroPagador não pode ser vazio e precisa ter tamanho máximo de 40";

            if (EstaVazio(entidade.municipioPagador) || entidade.municipioPagador.Length > 30)
                yield return "Campo municipioPagador não pode ser vazio e precisa ter tamanho máximo de 30";

            if (EstaVazio(entidade.ufPagador) || entidade.ufPagador.Length > 2)
                yield return "Campo ufPagador não pode ser vazio e precisa ter tamanho máximo de 2";

            if (EstaVazio(entidade.cdIndCpfcnpjPagador) || entidade.cdIndCpfcnpjPagador.Length > 1)
                yield return "Campo cdIndCpfcnpjPagador não pode ser vazio e precisa ter tamanho máximo de 1";

            if (EstaVazio(entidade.nuCpfcnpjPagador) || entidade.nuCpfcnpjPagador.Length > 14)
                yield return "Campo nuCpfcnpjPagador não pode ser vazio e precisa ter tamanho máximo de 14";

            if (!EstaVazio(entidade.nomeSacadorAvalista))
            {
                if (EstaVazio(entidade.logradouroSacadorAvalista) || entidade.logradouroSacadorAvalista.Length > 40)
                    yield return "Campo logradouroSacadorAvalista não pode ser vazio e precisa ter tamanho máximo de 40, pois nomeSacadorAvalista foi informado";

                if (EstaVazio(entidade.nuLogradouroSacadorAvalista) || entidade.nuLogradouroSacadorAvalista.Length > 10)
                    yield return "Campo nuLogradouroSacadorAvalista não pode ser vazio e precisa ter tamanho máximo de 10, pois nomeSacadorAvalista foi informado";

                if (EstaVazio(entidade.cepSacadorAvalista) || entidade.cepSacadorAvalista.Length > 5)
                    yield return "Campo cepSacadorAvalista não pode ser vazio e precisa ter tamanho máximo de 5, pois nomeSacadorAvalista foi informado";

                if (EstaVazio(entidade.complementoCepSacadorAvalista) || entidade.complementoCepSacadorAvalista.Length > 3)
                    yield return "Campo complementoCepSacadorAvalista não pode ser vazio e precisa ter tamanho máximo de 3, pois nomeSacadorAvalista foi informado";

                if (EstaVazio(entidade.bairroSacadorAvalista) || entidade.bairroSacadorAvalista.Length > 40)
                    yield return "Campo bairroSacadorAvalista não pode ser vazio e precisa ter tamanho máximo de 40, pois nomeSacadorAvalista foi informado";

                if (EstaVazio(entidade.municipioSacadorAvalista) || entidade.municipioSacadorAvalista.Length > 40)
                    yield return "Campo municipioSacadorAvalista não pode ser vazio e precisa ter tamanho máximo de 40, pois nomeSacadorAvalista foi informado";

                if (EstaVazio(entidade.ufSacadorAvalista) || entidade.ufSacadorAvalista.Length > 2)
                    yield return "Campo ufSacadorAvalista não pode ser vazio e precisa ter tamanho máximo de 2, pois nomeSacadorAvalista foi informado";

                if (EstaVazio(entidade.cdIndCpfcnpjSacadorAvalista) || entidade.cdIndCpfcnpjSacadorAvalista.Length > 1)
                    yield return "Campo cdIndCpfcnpjSacadorAvalista não pode ser vazio e precisa ter tamanho máximo de 1, pois nomeSacadorAvalista foi informado";

                if (EstaVazio(entidade.nuCpfcnpjSacadorAvalista) || entidade.nuCpfcnpjSacadorAvalista.Length > 14)
                    yield return "Campo nuCpfcnpjSacadorAvalista não pode ser vazio e precisa ter tamanho máximo de 14, pois nomeSacadorAvalista foi informado";
            }

            //Campos não obrigatórios
            if (!EstaVazio(entidade.clubBanco) && entidade.clubBanco.Length > 10)
            {
                yield return "Campo clubBanco precisa ter tamanho máximo de 10";
            }

            if (!EstaVazio(entidade.cdTipoContrato) && entidade.cdTipoContrato.Length > 3)
            {
                yield return "Campo cdTipoContrato precisa ter tamanho máximo de 3";
            }

            if (!EstaVazio(entidade.nuSequenciaContrato) && entidade.nuSequenciaContrato.Length > 10)
            {
                yield return "Campo nuSequenciaContrato precisa ter tamanho máximo de 10";
            }

            if (!EstaVazio(entidade.eNuSequenciaContrato) && entidade.eNuSequenciaContrato.Length > 10)
            {
                yield return "Campo eNuSequenciaContrato precisa ter tamanho máximo de 10";
            }

            if (!EstaVazio(entidade.cdProduto) && entidade.cdProduto.Length > 8)
            {
                yield return "Campo cdProduto precisa ter tamanho máximo de 8";
            }

            if (!EstaVazio(entidade.nuTitulo) && entidade.nuTitulo.Length > 11)
            {
                yield return "Campo nuTitulo precisa ter tamanho máximo de 11";
            }

            if (!EstaVazio(entidade.tpProtestoAutomaticoNegativacao) && entidade.tpProtestoAutomaticoNegativacao.Length > 11)
            {
                yield return "Campo tpProtestoAutomaticoNegativacao precisa ter tamanho máximo de 2";
            }

            if (!EstaVazio(entidade.controleParticipante) && entidade.controleParticipante.Length > 25)
            {
                yield return "Campo controleParticipante precisa ter tamanho máximo de 25";
            }

            if (!EstaVazio(entidade.cdPagamentoParcial) && entidade.cdPagamentoParcial.Length > 1)
            {
                yield return "Campo cdPagamentoParcial precisa ter tamanho máximo de 1";
            }

            if (!EstaVazio(entidade.percentualJuros) && entidade.percentualJuros.Length > 8)
            {
                yield return "Campo percentualJuros precisa ter tamanho máximo de 8";
            }

            if (!EstaVazio(entidade.vlJuros) && entidade.vlJuros.Length > 17)
            {
                yield return "Campo vlJuros precisa ter tamanho máximo de 17";
            }

            if (!EstaVazio(entidade.qtdeDiasJuros) && entidade.qtdeDiasJuros.Length > 2)
            {
                yield return "Campo qtdeDiasJuros precisa ter tamanho máximo de 2";
            }

            if (!EstaVazio(entidade.percentualMulta) && entidade.percentualMulta.Length > 8)
            {
                yield return "Campo percentualMulta precisa ter tamanho máximo de 8";
            }

            if (!EstaVazio(entidade.vlMulta) && entidade.vlMulta.Length > 17)
            {
                yield return "Campo vlMulta precisa ter tamanho máximo de 17";
            }

            if (!EstaVazio(entidade.qtdeDiasMulta) && entidade.qtdeDiasMulta.Length > 3)
            {
                yield return "Campo qtdeDiasMulta precisa ter tamanho máximo de 3";
            }

            if (!EstaVazio(entidade.percentualDesconto1) && entidade.percentualDesconto1.Length > 8)
            {
                yield return "Campo percentualDesconto1 precisa ter tamanho máximo de 8";
            }

            if (!EstaVazio(entidade.vlDesconto1) && entidade.vlDesconto1.Length > 17)
            {
                yield return "Campo vlDesconto1 precisa ter tamanho máximo de 17";
            }

            if (!EstaVazio(entidade.percentualDesconto2) && entidade.percentualDesconto2.Length > 8)
            {
                yield return "Campo percentualDesconto2 precisa ter tamanho máximo de 8";
            }

            if (!EstaVazio(entidade.vlDesconto2) && entidade.vlDesconto2.Length > 17)
            {
                yield return "Campo vlDesconto2 precisa ter tamanho máximo de 17";
            }

            if (!EstaVazio(entidade.percentualDesconto3) && entidade.percentualDesconto3.Length > 8)
            {
                yield return "Campo percentualDesconto3 precisa ter tamanho máximo de 8";
            }

            if (!EstaVazio(entidade.vlDesconto3) && entidade.vlDesconto3.Length > 17)
            {
                yield return "Campo vlDesconto3 precisa ter tamanho máximo de 17";
            }

            if (!EstaVazio(entidade.percentualBonificacao) && entidade.percentualBonificacao.Length > 8)
            {
                yield return "Campo percentualBonificacao precisa ter tamanho máximo de 8";
            }

            if (!EstaVazio(entidade.vlBonificacao) && entidade.vlBonificacao.Length > 17)
            {
                yield return "Campo vlBonificacao precisa ter tamanho máximo de 17";
            }

            if (!EstaVazio(entidade.vlAbatimento) && entidade.vlAbatimento.Length > 17)
            {
                yield return "Campo vlAbatimento precisa ter tamanho máximo de 17";
            }

            if (!EstaVazio(entidade.complementoLogradouroPagador) && entidade.complementoLogradouroPagador.Length > 15)
            {
                yield return "Campo complementoLogradouroPagador precisa ter tamanho máximo de 15";
            }

            if (!EstaVazio(entidade.endEletronicoPagador) && entidade.endEletronicoPagador.Length > 70)
            {
                yield return "Campo endEletronicoPagador precisa ter tamanho máximo de 70";
            }

            if (!EstaVazio(entidade.nomeSacadorAvalista) && entidade.nomeSacadorAvalista.Length > 40)
            {
                yield return "Campo nomeSacadorAvalista precisa ter tamanho máximo de 40";
            }

            if (!EstaVazio(entidade.complementoLogradouroSacadorAvalista) && entidade.complementoLogradouroSacadorAvalista.Length > 15)
            {
                yield return "Campo complementoLogradouroSacadorAvalista precisa ter tamanho máximo de 15";
            }

            if (!EstaVazio(entidade.endEletronicoSacadorAvalista) && entidade.endEletronicoSacadorAvalista.Length > 70)
            {
                yield return "Campo endEletronicoSacadorAvalista precisa ter tamanho máximo de 70";
            }

        }

        private bool EstaVazio(string param)
        {
            if (string.IsNullOrWhiteSpace(param))
                return true;
            var converteu = long.TryParse(param, out long resultado);
            return converteu && resultado == 0;
        }

        private bool EstaVazioSemZero(string param)
        {
            if (string.IsNullOrWhiteSpace(param))
                return true;

            var converteu = long.TryParse(param, out long resultado);
            return converteu && resultado > 0;
        }

        public string ConverterParaJsonAspasSimples(EnvioRemessaCobrancaBradescoJson data)
        {
            var sb = new StringBuilder();
            using (var sw = new StringWriter(sb))
            {
                using (var writer = new JsonTextWriter(sw))
                {
                    writer.QuoteChar = '\"';

                    var ser = new JsonSerializer();
                    ser.Serialize(writer, data);
                }
            }
            return sb?.ToString().Replace("null", "\"0\""); ;
        }
    }
}
