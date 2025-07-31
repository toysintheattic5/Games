using Microsoft.AspNetCore.Mvc;

namespace Games.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Games : ControllerBase
    {
        public IActionResult Index()
        {
            return null;
        }
    }
}
