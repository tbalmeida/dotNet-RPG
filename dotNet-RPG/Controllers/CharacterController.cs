using dotNet_RPG.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace dotNet_RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase   // without view support
    {
        private static List<Character> characters= new List<Character>
        {
            new Character(),
            new Character { Name = "Sam" }
        };

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);
        }


        public IActionResult GetSingle()
        {
            return Ok(characters[0]);
        }
    }
}
