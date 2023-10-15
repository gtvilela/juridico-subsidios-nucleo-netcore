using Juridico.Subsidios.Nucleo.Domain.Models.DocumentoModels;

namespace Juridico.Subsidios.Nucleo.Domain.Interfaces.Gateways
{
    public interface IDocumentoGateway
    {
        DocumentoOutputModel ObterDadosDocumento(DocumentoInputModel documento);
    }
}