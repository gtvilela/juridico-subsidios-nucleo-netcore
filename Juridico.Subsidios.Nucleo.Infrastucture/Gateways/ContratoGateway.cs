using Juridico.Subsidios.Nucleo.Domain.Interfaces.Gateways;
using Juridico.Subsidios.Nucleo.Domain.Mocks;
using Juridico.Subsidios.Nucleo.Domain.Models;
using Newtonsoft.Json;

namespace Juridico.Subsidios.Nucleo.Infrastucture.Gateways
{
    public class ContratoGateway : IContratoGateway
    {

        public ContratoModel ObterDadosContrato(string contrato)
        {
            Console.WriteLine($"Busca de dados do contrato {contrato}.");
            //Mock da chamada de API do time de contratos
            return JsonConvert.DeserializeObject<ContratoModel>(ContratoMock.RETORNO_CONTRATO);
        }
    }
}
