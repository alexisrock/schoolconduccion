
using Application.UseCases.ObtenerMateriasByEstudiante;
using Application.UseCases.ObtenerRoles;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    /// <summary>
    /// Controller of rol
    /// </summary>

    [Route("api/[controller]")]
    [ApiController]

    public class ModulosController : ControllerBase
    {


        private readonly ISender _sender;

        /// <summary>
        /// Constructor
        /// </summary>
        public ModulosController(ISender sender)
        {
            this._sender = sender;
        }


        /// <summary>
        /// Metodo para obtener todas las materias por IdUsuario
        /// </summary>

        [HttpGet, Route("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll()
        {
            var listproducto = await _sender.Send(new ModulosRequest() { });
            return Ok(listproducto);
        }

    }
}
