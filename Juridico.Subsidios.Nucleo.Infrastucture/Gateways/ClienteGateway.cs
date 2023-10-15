using Juridico.Subsidios.Nucleo.Domain.Interfaces.Gateways;
using Juridico.Subsidios.Nucleo.Domain.Mocks;
using Juridico.Subsidios.Nucleo.Domain.Models;
using Newtonsoft.Json;

namespace Juridico.Subsidios.Nucleo.Infrastucture.Gateways
{
    public class ClienteGateway : IClienteGateway
    {
        public ClienteModel ObterDadosVeiculo(string codigoCliente)
        {
            Console.WriteLine($"Busca de dados do cliente de código {codigoCliente}.");
            //Mock da chamada de API do time do núcleo de clientes
            return JsonConvert.DeserializeObject<ClienteModel>(ClienteMock.RETORNO_CLIENTE);
        }
    }
}
