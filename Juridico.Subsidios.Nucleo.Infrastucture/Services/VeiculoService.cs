using Juridico.Subsidios.Nucleo.Domain.Enums;
using Juridico.Subsidios.Nucleo.Domain.Interfaces.Gateways;
using Juridico.Subsidios.Nucleo.Domain.Models.AclModels;
using Juridico.Subsidios.Nucleo.Domain.Models;
using Juridico.Subsidios.Nucleo.Domain.Utils;
using Juridico.Subsidios.Nucleo.Domain.Interfaces.Services;

namespace Juridico.Subsidios.Nucleo.Infrastucture.Services
{
    public class VeiculoService : IInformacaoAdicionalService
    {
        private readonly IVeiculoGateway veiculoGateway;
        private readonly IAclGateway aclGateway;

        public VeiculoService(IVeiculoGateway veiculoGateway)
        {
            this.veiculoGateway = veiculoGateway;
        }

        public List<StatusProcessamentoModel> ProcessarInformacaoAdicional(string codigo, string codigoProcesso)
        {
            var codigoTipoInformacaoAdicional = "1";
            var listaStatus = new List<StatusProcessamentoModel>();
            var veiculo = veiculoGateway.ObterDadosVeiculo(codigo);
            var statusBusca = (veiculo is null || string.IsNullOrEmpty(veiculo.Placa))
                                         ? StatusUtil.FALHA_INFOADD_BUSCA_SUBSIDIOS
                                         : StatusUtil.OK_INFOADD_BUSCA_SUBSIDIOS;

            #region Envio da informação adicional ano do modelo do veículo ao fornecedor
            EnvioSubsidio(codigoProcesso, codigoTipoInformacaoAdicional, listaStatus, veiculo, statusBusca, "Ano Modelo", veiculo.AnoModelo);
            #endregion

            #region Envio da informação adicional modelo do veículo ao fornecedor
            EnvioSubsidio(codigoProcesso, codigoTipoInformacaoAdicional, listaStatus, veiculo, statusBusca, "Modelo", veiculo.Modelo);
            #endregion

            #region Envio da informação adicional placa do veículo ao fornecedor
            EnvioSubsidio(codigoProcesso, codigoTipoInformacaoAdicional, listaStatus, veiculo, statusBusca, "Placa", veiculo.Placa);
            #endregion



            return listaStatus;
        }
        #region Métodos privados
        private void EnvioSubsidio(
                                    string codigoProcesso, 
                                    string codigoTipoInformacaoAdicional, 
                                    List<StatusProcessamentoModel> listaStatus, 
                                    VeiculoModel? veiculo, 
                                    string statusBusca,
                                    string nomeInformacaoAdicional,
                                    string valorInformacaoAdicional)
        {
            listaStatus.Add(StatusUtil.MontarStatusProcessamento(nomeInformacaoAdicional, 
                                                                 valorInformacaoAdicional, 
                                                                 TipoSubsidio.InformacaoAdicional, 
                                                                 TipoProcessamento.BuscaSubsidio, 
                                                                 statusBusca));

            var informacaoAdicional = new InformacaoAdicionalAclModel()
            {
                CodigoProcesso = Convert.ToInt32(codigoProcesso),
                CodigoTipo = Convert.ToInt32(codigoTipoInformacaoAdicional),
                Nome = nomeInformacaoAdicional,
                Valor = valorInformacaoAdicional,
                Usuario = "999999",
                Descricao = ""
            };
            var retornoAnoModeloAcl = aclGateway.InserirInformacaoAdicional(informacaoAdicional).Result;
            var statusEnvio = string.IsNullOrEmpty(retornoAnoModeloAcl)
                                        ? StatusUtil.FALHA_DOC_ENVIO_FORNECEDOR
                                        : retornoAnoModeloAcl;
            listaStatus.Add(StatusUtil.MontarStatusProcessamento(informacaoAdicional.Nome, 
                                                                 informacaoAdicional.Valor, 
                                                                 TipoSubsidio.InformacaoAdicional, 
                                                                 TipoProcessamento.EnvioAoFornecedor, 
                                                                 statusEnvio));
        }
        #endregion
    }
}
