namespace Juridico.Subsidios.Nucleo.Domain.Models
{
    public class ContratoModel
    {
        public string CodigoContrato { get; set; }
        public string Origem { get; set; }
        public string Status { get; set; }
        public string TipoDePagamento { get; set; }
        public string CodigoReserva { get; set; }
        public string DataInicioVigencia { get; set; }
        public string DataFimVigencia { get; set; }
    }
}
