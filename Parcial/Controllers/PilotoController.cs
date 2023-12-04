using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using ProyectoBackendMiguelVillca.Models;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PilotoController:ControllerBase
    {
        private readonly ILogger<PilotoController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public PilotoController(
            ILogger<PilotoController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create:
        [Route("{IdNumeroLicencia}")]
        [HttpPost]
        public IActionResult PostPilotos(
            [FromBody] Pilotos piloto)
        {
            _aplicacionContexto.Pilotos.Add(piloto);
            _aplicacionContexto.SaveChanges();
            return Ok(piloto);
        }
        //READ: 
        [Route("{IdNumeroLicencia}")]
        [HttpGet]
        public IEnumerable<Pilotos> GetMusica()
        {
            return _aplicacionContexto.Pilotos.ToList();
        }
        //Update: 
        [Route("{IdPilotos}")]
        [HttpPut]
        public IActionResult PutPilotos([FromBody] Pilotos piloto)
        {
            _aplicacionContexto.Pilotos.Update(piloto);
            _aplicacionContexto.SaveChanges();
            return Ok(piloto);
        }
        //Delete: 
        [Route("{IdPilotos}")]
        [HttpDelete]
        public IActionResult DeletePilotos(int pilotoID)
        {
            _aplicacionContexto.Pilotos.Remove(
                _aplicacionContexto.Pilotos.ToList()
                .Where(x => x.IdNumeroLicencia == pilotoID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(pilotoID);
        }
    }
}
