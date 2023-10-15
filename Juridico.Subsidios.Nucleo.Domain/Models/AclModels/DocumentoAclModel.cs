namespace Juridico.Subsidios.Nucleo.Domain.Models.AclModels
{
    public class DocumentoAclModel
    {
        public string Nome { get; set; }
        public int CodigoTipo { get; set; }
        public string Tipo { get; set; }
        public int CodigoProcesso { get; set; }
        public string Base64 { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string Usuario { get; set; }

    }
}
