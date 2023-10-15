using Juridico.Subsidios.Nucleo.Domain.Models;

namespace Juridico.Subsidios.Nucleo.Domain.Interfaces.Services
{
    public interface IInformacaoAdicionalService
    {
        List<StatusProcessamentoModel> ProcessarInformacaoAdicional(string codigo, string codigoProcesso);
    }
}
