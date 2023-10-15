using Juridico.Subsidios.Nucleo.Domain.Interfaces.Gateways;
using Juridico.Subsidios.Nucleo.Domain.Models.AclModels;
using System.Text;

namespace Juridico.Subsidios.Nucleo.Infrastucture.Gateways
{
    public class AclGateway : IAclGateway
    {
        private readonly HttpClient _httpClient;

        public AclGateway(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> InserirDocumento(DocumentoAclModel documento)
        {
            var url = _httpClient.BaseAddress.AbsoluteUri + $"/api/v1/Processo/Documento";
            var content = new StringContent(documento.ToString(), Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync(url, content);
            return await result.Content.ReadAsStringAsync();
        }
    }
}
