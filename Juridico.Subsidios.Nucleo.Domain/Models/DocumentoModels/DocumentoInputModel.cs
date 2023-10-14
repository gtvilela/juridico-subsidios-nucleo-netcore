namespace Juridico.Subsidios.Nucleo.Domain.Models.DocumentoModels
{
    public class DocumentoInputModel
    {
        /// <summary>
        /// Data início de armazenamento
        /// </summary>
        public string DataInicioArmazenamento { get; set; }
        /// <summary>
        /// Data sim de armazenamento
        /// </summary>
        public string DataFimArmazenamento { get; set; }
        /// <summary>
        /// Dados retornados com chave e valor
        /// </summary>
        public List<Metadado> MetadadosBusca { get; set; }
    }
}
