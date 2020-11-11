using dotNet_RPG.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotNet_RPG.Service.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAllCharacters();

        Task<Character> GetCharacterById(int id);

        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}
