namespace Juridico.Subsidios.Nucleo.Domain.Models.AclModels
{
    public class AndamentoAclModel
    {
        public int CodigoTipo { get; set; }
        public string Tipo { get; set; }
        public int CodigoProcesso { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public string DataConclusao { get; set; }
        public int Prazo { get; set; }
        public string Usuario { get; set; }
    }
}
