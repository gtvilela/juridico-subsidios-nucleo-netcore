﻿using Juridico.Subsidios.Nucleo.Domain.Interfaces.Gateways;
using Juridico.Subsidios.Nucleo.Domain.Mocks;
using Juridico.Subsidios.Nucleo.Domain.Models;
using Newtonsoft.Json;

namespace Juridico.Subsidios.Nucleo.Infrastucture.Gateways
{
    public class VeiculoGateway : IVeiculoGateway
    {
        public VeiculoModel ObterDadosVeiculo(string placa)
        {
            Console.WriteLine($"Busca de dados do veículo {placa}.");
            //Mock da chamada de API do time de veículos
            return JsonConvert.DeserializeObject<VeiculoModel>(VeiculoMock.RETORNO_VEICULO);
        }
    }
}
