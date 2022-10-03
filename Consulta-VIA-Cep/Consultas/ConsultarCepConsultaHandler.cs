using Consulta_VIA_Cep.Comum;
using Consulta_VIA_Cep.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Consulta_VIA_Cep.Consultas
{
    public class ConsultarCepConsultaHandler : IRequestHandler<ConsultarCepConsulta, RetornoPersonalizado>
    {
        private readonly IConsultarCepServico _consultarCepServico;

        public ConsultarCepConsultaHandler(IConsultarCepServico consultarCepServico)
        {
            _consultarCepServico = consultarCepServico;
        }

        public async Task<RetornoPersonalizado> Handle(ConsultarCepConsulta request, CancellationToken cancellationToken)
        {
            var erros = ValidarConsulta(request);

            if (erros.Any())
            {
                return new RetornoPersonalizado(false, "Ocorreu um erro durante a consulta", erros);
            }

            var endereco = await _consultarCepServico.ConsultarCep(request.Cep);

            return new RetornoPersonalizado(true, "Consulta realizada com sucesso", endereco);
        }

        private static List<string> ValidarConsulta(ConsultarCepConsulta request)
        {
            var erros = new List<string>();
            var validationResult = new ConsultarCepConsultaValidador();
            var result = validationResult.Validate(request);

            if (!result.IsValid)
            {
                foreach (var erro in result.Errors)
                {
                    erros.Add(erro.ErrorMessage);
                }

                return erros;
            }

            return erros;
        }
    }
}