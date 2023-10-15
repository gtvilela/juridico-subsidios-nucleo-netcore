using Juridico.Subsidios.Nucleo.Domain.Interfaces.Gateways;
using Juridico.Subsidios.Nucleo.Infrastucture.Gateways;
using Microsoft.Extensions.DependencyInjection;

namespace Juridico.Subsidios.Nucleo.Infrastucture
{
    public static class Setup
    {

        public static IServiceCollection AddInfrastucture(this IServiceCollection services)
        {

            services.AddScoped<IClienteGateway, ClienteGateway>();
            services.AddScoped<IContratoGateway, ContratoGateway>();
            services.AddScoped<IDocumentoGateway, DocumentoGateway>();
            services.AddScoped<IVeiculoGateway, VeiculoGateway>();

            //services.AddHttpClient<IAclGateway, AclGateway>(client =>
            //{
            //    var clientId = Environment.GetEnvironmentVariable(InfraEnvironmentVariables.ClientIdAcl);
            //    if (!string.IsNullOrWhiteSpace(clientId))
            //        client.DefaultRequestHeaders.Add("client_id", clientId);
            //    else
            //        throw new ArgumentException($"{InfraEnvironmentVariables.ClientIdAcl} não pode ser nulo ou vazio");

            //    client.BaseAddress = new Uri(Environment.GetEnvironmentVariable(InfraEnvironmentVariables.UrlAlContratos));
            //}).AddPolicyHandler(PollyConfig.RetryPolicyBasico());

            return services;
        }
    }
}
