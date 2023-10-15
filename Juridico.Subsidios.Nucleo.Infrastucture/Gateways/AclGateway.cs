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
           var result = await Post("/Documento",documento.ToString());
            return await result.Content.ReadAsStringAsync();
        }

        public async Task<string> InserirInformacaoAdicional(InformacaoAdicionalAclModel informacaoAdicional)
        {
            var result = await Post("/InformacaoAdicional", informacaoAdicional.ToString());
            return await result.Content.ReadAsStringAsync();
        }

        public async Task<string> InserirAndamento(AndamentoAclModel andamento)
        {
            var result = await Post("/Andamento", andamento.ToString());
            return await result.Content.ReadAsStringAsync();
        }

        private async Task<HttpResponseMessage> Post(string rota, string subsidio)
        {
            var url = _httpClient.BaseAddress.AbsoluteUri + rota;
            var content = new StringContent(subsidio, Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync(url, content);
            return result;
        }

        
    }
}
