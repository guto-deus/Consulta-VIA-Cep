using Consulta_VIA_Cep.ViewModels;
using System.Threading.Tasks;

namespace Consulta_VIA_Cep.Interfaces
{
    public interface IConsultarCepServico
    {
        Task<ConsultarCepViewModel> ConsultarCep(string cep);
    }
}