using DTOLayer;
using System.Collections.Generic;

namespace Patient.BusinessLayer.INTERFACE
{
    public interface IPetManager
    {
        List<PetDto> GetAllPets();
        bool AddPet(PetDto p);
        PetDto GetPetById(long id);
        List<PetDto> GetAllPetsByOwnerID(long ownerId);
        bool EditPet(PetDto pet);
        bool DeletePetById(long petId);

    }
}
