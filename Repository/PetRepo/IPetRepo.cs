using Patients.DALayer.MODELS.ENTITIES;
using System.Collections.Generic;

namespace Repository.PetRepo
{
    public interface IPetRepo
    {
        List<Pet> GetAllPets();
        bool AddPet(Pet pet);
        Pet GetPetById(long id);
        List<Pet> GetAllPetsByOwnerID(long ownerId);
        bool EditPet(Pet pet);
        bool DeletePetById(long petId);
    }
}
