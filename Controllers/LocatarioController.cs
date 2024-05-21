using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IntegradorBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocatarioController : ControllerBase
    {
        public LocatarioController()
        {
                
        }

        [HttpGet]
        public async Task<IActionResult> GetTodos()
        {
            return Ok();
        }
    }
}
