using MagicVilla_API.Datos;
using MagicVilla_API.Modelos;
using MagicVilla_API.Modelos.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public ActionResult< IEnumerable<VillaDto>> GetVillas()
        {
            return Ok( VillaStore.VillaList);
          
        }

        [HttpGet("Id:int")]
        public ActionResult<VillaDto> GetVilla(int id)
        {
            if (id == 0)
            { return BadRequest(); }
            return Ok(VillaStore.VillaList.FirstOrDefault(v => v.Id == id));
        }
    }
}
