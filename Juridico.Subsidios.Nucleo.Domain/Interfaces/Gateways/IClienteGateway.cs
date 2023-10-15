using Juridico.Subsidios.Nucleo.Domain.Models;

namespace Juridico.Subsidios.Nucleo.Domain.Interfaces.Gateways
{
    public interface IClienteGateway
    {
        ClienteModel ObterDadosCliente(string codigoCliente);
    }
}