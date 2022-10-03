using System.Collections.Generic;

namespace Consulta_VIA_Cep.ViewModels
{
    public class ConsultarCepViewModel
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public bool Erro { get; set; }
    }
}