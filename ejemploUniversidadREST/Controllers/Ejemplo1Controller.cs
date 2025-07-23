using Microsoft.AspNetCore.Mvc;

namespace ejemploUniversidadREST.Controllers
{
    [Route("api/Ejemplo1")] // http://localhost:5128/api/ejemplo1
    public class Ejemplo1Controller : ControllerBase
    {
        [HttpGet("prueba1")] // http://localhost:5128/api/ejemplo1/prueba1
        public async Task<IActionResult> prueba1()
        {
            try
            {
                return Ok("Prueba 1 exitosa");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
