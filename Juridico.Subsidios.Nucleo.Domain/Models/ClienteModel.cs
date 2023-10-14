namespace Juridico.Subsidios.Nucleo.Domain.Models
{
    public class ClienteModel
    {
        public long CodigoCliente { get; set; }
        public string Nome { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public long Segmento { get; set; }
        public string Documento { get; set; }
        public bool Ativo { get; set; }
        public string NomeSegmento { get; set; }
        public string CentroOperacao { get; set; }
        public bool AtivoNpc { get; set; }
    }
}
