using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character {Id = 1, Name = "Sam"}
        };

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>
            {
                Data = characters
            };
            return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>
            {
                Data = characters.FirstOrDefault(c => c.Id == id)
            };
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            var serviceResponse = new ServiceResponse<List<Character>>
            {
                Data = characters
            };

            return serviceResponse;
        }
    }
}