using dotNet_RPG.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotNet_RPG.Service.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAllCharacters();

        Task<ServiceResponse<Character>> GetCharacterById(int id);

        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}
