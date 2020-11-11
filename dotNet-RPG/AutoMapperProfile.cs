using AutoMapper;
using dotNet_RPG.DTOs.Character;
using dotNet_RPG.Models;

namespace dotNet_RPG
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDTO>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}
