using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Subsidios.Nucleo.Domain.Models.DocumentoModels
{
    public class DocumentoOutputModel
    {
        public string IdentificadorArquivo { get; set; }
        public string NomeArquivo { get; set; }
        public string DataCriacaoArquivo { get; set; }
        public string LinkArquivo { get; set; }
        public string Arquivo { get; set; }
        public string Hash { get; set; }
        public string TamanhoArquivo { get; set; }
        public List<Metadado> Metadados { get; set; }
        public string CodigoCliente { get; set; }
    }
}
