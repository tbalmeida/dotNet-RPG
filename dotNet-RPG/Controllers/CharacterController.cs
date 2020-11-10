using dotNet_RPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotNet_RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase   // without view support
    {
        private static Character knight = new Character();

        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}
