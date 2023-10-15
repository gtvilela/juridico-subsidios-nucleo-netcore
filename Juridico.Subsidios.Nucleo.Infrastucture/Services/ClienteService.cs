using Juridico.Subsidios.Nucleo.Domain.Contants;
using Juridico.Subsidios.Nucleo.Domain.Enums;
using Juridico.Subsidios.Nucleo.Domain.Interfaces.Gateways;
using Juridico.Subsidios.Nucleo.Domain.Interfaces.Services;
using Juridico.Subsidios.Nucleo.Domain.Models;
using Juridico.Subsidios.Nucleo.Domain.Models.AclModels;
using Juridico.Subsidios.Nucleo.Domain.Utils;

namespace Juridico.Subsidios.Nucleo.Infrastucture.Services
{
    public class ClienteService : IInformacaoAdicionalService
    {
        private readonly IClienteGateway clienteGateway;
        private readonly IAclGateway aclGateway;

        public ClienteService(IClienteGateway clienteGateway)
        {
            this.clienteGateway = clienteGateway;
        }

        public List<StatusProcessamentoModel> ProcessarInformacaoAdicional(string codigo, string codigoProcesso, string codigoTipoInformacaoAdicional)
        {
            var listaStatus = new List<StatusProcessamentoModel>();
            var cliente = clienteGateway.ObterDadosCliente(codigo);
            var statusBusca = (cliente is null || string.IsNullOrEmpty(cliente.CodigoCliente))
                                         ? StatusUtil.FALHA_INFOADD_BUSCA_SUBSIDIOS
                                         : StatusUtil.OK_INFOADD_BUSCA_SUBSIDIOS;
            listaStatus.Add(StatusUtil.MontarStatusProcessamento("Segmento Cliente", cliente.Segmento, TipoSubsidio.InformacaoAdicional, TipoProcessamento.BuscaSubsidio, statusBusca));

            var informacaoAdicional = new InformacaoAdicionalAclModel()
            {
                CodigoProcesso = Convert.ToInt32(codigoProcesso),
                CodigoTipo = Convert.ToInt32(codigoTipoInformacaoAdicional),
                Nome = "Segmento Cliente",
                Valor = cliente.NomeSegmento,
                Usuario = "999999",
                Descricao = ""
            };

            var retornoAcl = aclGateway.InserirInformacaoAdicional(informacaoAdicional).Result;
            var statusEnvio = string.IsNullOrEmpty(retornoAcl)
                                        ? StatusUtil.FALHA_DOC_ENVIO_FORNECEDOR
                                        : retornoAcl;
            listaStatus.Add(StatusUtil.MontarStatusProcessamento(informacaoAdicional.Nome, informacaoAdicional.Valor, TipoSubsidio.InformacaoAdicional, TipoProcessamento.EnvioAoFornecedor, statusEnvio));

            return listaStatus;
        }

    }
}
