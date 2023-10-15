using Juridico.Subsidios.Nucleo.Domain.Models.AclModels;

namespace Juridico.Subsidios.Nucleo.Domain.Interfaces.Gateways
{
    public interface IAclGateway
    {
        Task<string> InserirDocumento(DocumentoAclModel documento);
        Task<string> InserirInformacaoAdicional(InformacaoAdicionalAclModel informacaoAdicional);
        Task<string> InserirAndamento(AndamentoAclModel andamento);
    }
}