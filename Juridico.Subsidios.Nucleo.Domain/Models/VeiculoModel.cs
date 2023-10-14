namespace Juridico.Subsidios.Nucleo.Domain.Models
{
    public class VeiculoModel
    {
        public string CodigoVeiculo { get; set; }
        public string Placa { get; set; }
        public string Grupo { get; set; }
        public string CodigoModelo { get; set; }
        public string CodigoFabricante { get; set; }
        public string HodometroRetirada { get; set; }
        public string HodometroDevolucao { get; set; }
        public string TanqueSaida { get; set; }
        public string TanqueRetorno { get; set; }
        public string UltimoContrato { get; set; }
    }
}
