using Consulta_VIA_Cep.Interfaces;
using Consulta_VIA_Cep.ViewModels;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Consulta_VIA_Cep.Servicos
{
    public class ConsultarCepServico : IConsultarCepServico
    {
        public async Task<ConsultarCepViewModel> ConsultarCep(string cep)
        {
            var client = new HttpClient();

            var respostaIntegracao = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");

            var jsonRetorno = await respostaIntegracao.Content.ReadAsStringAsync();

            var endereco = JsonConvert.DeserializeObject<ConsultarCepViewModel>(jsonRetorno);

            if (endereco.Erro)
            {
                throw new Exception("CEP não encontrado na base de dados");
            }

            return endereco;
        }
    }
}