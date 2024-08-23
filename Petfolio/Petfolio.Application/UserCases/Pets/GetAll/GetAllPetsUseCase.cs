using Petfolio.Communication.Responses;

namespace Petfolio.Application.UserCases.Pets.GetAll
{
    public class GetAllPetsUseCase
    {
        public ResponseAllPetJson Execute()
        {
            return new ResponseAllPetJson
            {
                Pets = new List<ResponseShortPetJson>
                {
                    new ResponseShortPetJson
                    {
                        Id = 1,
                        Name = "Lenilson",
                        Type = Communication.Enums.PetType.Dog
                    }
                }
            };
        }
    }
}
