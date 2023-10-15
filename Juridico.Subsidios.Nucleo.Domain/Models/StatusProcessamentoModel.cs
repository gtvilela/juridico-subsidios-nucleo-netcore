using Juridico.Subsidios.Nucleo.Domain.Enums;

namespace Juridico.Subsidios.Nucleo.Domain.Models
{
    public class StatusProcessamentoModel
    {
        public TipoSubsidio TipoSubsidio { get; set; }

        public Dictionary<string, string> Subsidio { get; set; }

        public TipoProcessamento TipoProcessamento { get; set; }

        public string Status { get; set; }
    }
}
