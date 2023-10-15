using Juridico.Subsidios.Nucleo.Domain.Interfaces.Gateways;
using Juridico.Subsidios.Nucleo.Domain.Mocks;
using Juridico.Subsidios.Nucleo.Domain.Models.DocumentoModels;
using Newtonsoft.Json;

namespace Juridico.Subsidios.Nucleo.Infrastucture.Gateways
{
    public class DocumentoGateway : IDocumentoGateway
    {
        public DocumentoOutputModel ObterDadosDocumento(DocumentoInputModel documento)
        {
            var siglaDocumento = documento.MetadadosBusca.Where(d => d.Nome == "SiglaDocumento").First().Valor;
            Console.WriteLine($"Buscando documentos referentes à sigla {siglaDocumento}");
            //Mock da chamada de API do time de gestão de documentos
            return siglaDocumento switch
            {
                "CRLV" => JsonConvert.DeserializeObject<DocumentoOutputModel>(DocumentoMock.RETORNO_CRLV),
                "CTT" => JsonConvert.DeserializeObject<DocumentoOutputModel>(DocumentoMock.RETORNO_CTT),
                "BO" => JsonConvert.DeserializeObject<DocumentoOutputModel>(DocumentoMock.RETORNO_BO),
                "CPPAG" => JsonConvert.DeserializeObject<DocumentoOutputModel>(DocumentoMock.RETORNO_CPPAG),
                "CNH" => JsonConvert.DeserializeObject<DocumentoOutputModel>(DocumentoMock.RETORNO_CNH),
                _ => new DocumentoOutputModel(),
            };
        }
    }
}
