using DTOLayer;
using Patients.DALayer.MODELS.ENTITIES;

namespace Patient.BusinessLayer.MAPPER
{
    public class PetDtoMapper
    {
        public Pet mapDto(PetDto dtoPet)
        {
            var _petDto = new Pet
            {
                PetId = dtoPet.PetId,
                PetName = dtoPet.PetName,
                Allergies = dtoPet.Allergies,
                BloodGroup = dtoPet.BloodGroup,
                DOB = dtoPet.DOB,
                Breed = dtoPet.Breed,
                Gender = dtoPet.Gender,
                ImageUrl = dtoPet.ImageUrl,
                Species = dtoPet.Species
            };
            return _petDto;
        }

        public PetDto mapEntity(Pet pet)
        {
            var _pet = new PetDto
            {
                PetId = pet.PetId,
                PetName = pet.PetName,
                Allergies = pet.Allergies,
                BloodGroup = pet.BloodGroup,
                DOB = pet.DOB,
                Breed = pet.Breed,
                Gender = pet.Gender,
                ImageUrl = pet.ImageUrl,
                Species = pet.Species
            };
            return _pet;
        }
    }
}
