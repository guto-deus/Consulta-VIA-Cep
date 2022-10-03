using FluentValidation;
using System.Text.RegularExpressions;

namespace Consulta_VIA_Cep.Consultas
{
    public class ConsultarCepConsultaValidador : AbstractValidator<ConsultarCepConsulta>
    {
        public ConsultarCepConsultaValidador()
        {
            RuleFor(p => p.Cep)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("O cep não foi informado.")
                .Must(ValidarCep)
                .WithMessage("Não foi possível realizar a operação, pois o cep de número {PropertyValue} informado não é válido.");
        }

        private static bool ValidarCep(string cep)
        {
            if (cep.Length == 8)
            {
                cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);
            }

            return Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
        }
    }
}