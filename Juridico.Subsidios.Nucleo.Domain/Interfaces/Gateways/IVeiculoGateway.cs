using Juridico.Subsidios.Nucleo.Domain.Models;

namespace Juridico.Subsidios.Nucleo.Domain.Interfaces.Gateways
{
    public interface IVeiculoGateway
    {
        VeiculoModel ObterDadosVeiculo(string placa);
    }
}