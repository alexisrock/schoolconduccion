

using Application.UseCases.ObtenerMateriasByEstudiante;
using Application.UseCases.ObtenerEstudiantes;
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
 
    public class EstudianteController : ControllerBase
    {
        private readonly ISender _sender;

        /// <summary>
        /// Constructor
        /// </summary>
        public EstudianteController(ISender sender)
        {
            this._sender = sender;
        }




        /// <summary>
        /// Metodo para obtener por materia todos estudiantes   
        /// </summary>

        [HttpGet, Route("[action]")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllEstudiantes()
        {
            var listproducto = await _sender.Send(new ObtenerEstudianteRequest() {  });
            return Ok(listproducto);
        }
    }
}
