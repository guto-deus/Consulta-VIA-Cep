using Consulta_VIA_Cep.Interfaces;
using Consulta_VIA_Cep.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace Consulta_VIA_Cep.Configuracoes
{
    public static class ConfiguracaoInjecaoDependencias
    {
        public static IServiceCollection ResolverDependencias(this IServiceCollection services)
        {
            services.AddScoped<IConsultarCepServico, ConsultarCepServico>();

            services.AddMvc();

            return services;
        }
    }
}