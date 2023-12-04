using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvionController : ControllerBase
    {
        private readonly ILogger<AvionController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public AvionController(
            ILogger<AvionController> logger, 
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create:
        [Route("{IdAviones}")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Aviones avion)
        {
            _aplicacionContexto.Aviones.Add(avion);
            _aplicacionContexto.SaveChanges();
            return Ok(avion);
        }
        //READ: 
        [Route("{IdAviones}")]
        [HttpGet]
        public IEnumerable<Aviones> Get()
        {
            return _aplicacionContexto.Aviones.ToList();
        }
        //Update: 
        [Route("{IdAviones}")]
        [HttpPut]
        public IActionResult Put([FromBody] Aviones avion)
        {
            _aplicacionContexto.Aviones.Update(avion);
            _aplicacionContexto.SaveChanges();
            return Ok(avion);
        }
        //Delete: 
        [Route("{IdAviones}")]
        [HttpDelete]
        public IActionResult Delete(int avionID)
        {
            _aplicacionContexto.Aviones.Remove(
                _aplicacionContexto.Aviones.ToList()
                .Where(x=>x.IdAviones== avionID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(avionID);
        }
    }
}