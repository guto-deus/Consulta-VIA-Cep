using Consulta_VIA_Cep.Consultas;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Threading.Tasks;

namespace Consulta_VIA_Cep.Controllers
{
    [Route("api/consulta-via-cep")]
    public class ConsultarCepController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ConsultarCepController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("consultar-cep")]
        [AllowAnonymous]
        public async Task<IActionResult> ConsultarCep([FromBody] ConsultarCepConsulta consulta)
        {
            return Ok(await _mediator.Send(consulta));
        }
    }
}