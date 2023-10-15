using Juridico.Subsidios.Nucleo.Domain.Enums;
using Juridico.Subsidios.Nucleo.Domain.Models;

namespace Juridico.Subsidios.Nucleo.Domain.Utils
{
    public static class StatusUtil
    {

        public const string FALHA_INFOADD_BUSCA_SUBSIDIOS = "Erro ao buscar informação adicional.";
        public const string FALHA_INFOADD_ENVIO_FORNECEDOR = "Erro ao enviar informação adicional ao fornecedor.";
        public const string OK_INFOADD_BUSCA_SUBSIDIOS = "Informação adicional retornada com sucesso.";
        public const string OK_INFOADD_ENVIO_FORNECEDOR = "Informação adicional enviada ao fornecedor com sucesso.";

        public const string FALHA_DOC_BUSCA_SUBSIDIOS = "Erro ao buscar documento.";
        public const string FALHA_DOC_ENVIO_FORNECEDOR = "Erro ao enviar o documento ao fornecedor.";
        public const string OK_DOC_BUSCA_SUBSIDIOS = "Documento retornado com sucesso.";
        public const string OK_DOC_ENVIO_FORNECEDOR = "Documento enviado ao fornecedor com sucesso.";

        public static StatusProcessamentoModel MontarStatusProcessamento(string chave, 
                                                                         string valor, 
                                                                         TipoSubsidio tipoSubsidio, 
                                                                         TipoProcessamento tipoProcessamento, 
                                                                         string status)
        {
            var subsidio = new Dictionary<string, string> { { chave, valor } };
            var retornoBuscaSubsidios = new StatusProcessamentoModel()
            {
                TipoSubsidio = tipoSubsidio,
                TipoProcessamento = tipoProcessamento,
                Status = status,
                Subsidio = subsidio
            };

            return retornoBuscaSubsidios;
        }
    }
}
