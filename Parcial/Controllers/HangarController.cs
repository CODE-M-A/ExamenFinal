using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HangarController:ControllerBase
    {
        private readonly ILogger<HangarController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public HangarController(
            ILogger<HangarController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create:
        [Route("{IdHangar}")]
        [HttpPost]
        public IActionResult PostHangar(
            [FromBody] Hangares hangar)
        {
            _aplicacionContexto.Hangares.Add(hangar);
            _aplicacionContexto.SaveChanges();
            return Ok(hangar);
        }
        //READ: 
        [Route("{IdHangares}")]
        [HttpGet]
        public IEnumerable<Hangares> GetHangares()
        {
            return _aplicacionContexto.Hangares.ToList();
        }
        //Update:
        [Route("{IdHangares}")]
        [HttpPut]
        public IActionResult PutHangares([FromBody] Hangares hangar)
        {
            _aplicacionContexto.Hangares.Update(hangar);
            _aplicacionContexto.SaveChanges();
            return Ok(hangar);
        }
        //Delete:
        [Route("{IDHangares}")]
        [HttpDelete]
        public IActionResult DeleteHangares(int hangarID)
        {
            _aplicacionContexto.Hangares.Remove(
                _aplicacionContexto.Hangares.ToList()
                .Where(x => x.IdHangar == hangarID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(hangarID);
        }
    }
}
