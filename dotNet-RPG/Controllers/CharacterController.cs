using dotNet_RPG.Models;
using dotNet_RPG.Service.CharacterService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace dotNet_RPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase   // without view support
    {

        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok( await _characterService.GetAllCharacters() );
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok( await _characterService.GetCharacterById(id) );
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(Character newCharacter)
        {
            return Ok( await _characterService.AddCharacter(newCharacter));
        }
    }
}
