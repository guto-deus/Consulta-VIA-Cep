using Consulta_VIA_Cep.Comum;
using MediatR;

namespace Consulta_VIA_Cep.Consultas
{
    public class ConsultarCepConsulta : IRequest<RetornoPersonalizado>
    {
        public string Cep { get; set; }

        public ConsultarCepConsulta(string cep)
        {
            Cep = cep;
        }
    }
}