using BackFecha.Servicio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebApiFecha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiFecha : ControllerBase
    {
        private readonly IManager _fechaManager;
        public ApiFecha(IManager fecha)
        {
            _fechaManager = fecha;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                if(_fechaManager != null)
                {
                    var fecha = _fechaManager.ObtenerFecha();
                    return Ok(fecha);
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
