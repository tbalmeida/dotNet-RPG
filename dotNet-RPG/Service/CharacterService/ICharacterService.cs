using dotNet_RPG.DTOs.Character;
using dotNet_RPG.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotNet_RPG.Service.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters();

        Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);

        Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDto newCharacter);
    }
}
