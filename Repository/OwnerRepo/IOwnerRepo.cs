using Patients.DALayer.MODELS.ENTITIES;
using System.Collections.Generic;

namespace Repository.OwnerRepo
{
    public interface IOwnerRepo
    {
        List<Owner> GetAllOwners();
        bool AddOwner(Owner owner);
        bool GetOwnerById(long id);
        bool EditOwner(Owner owner);
       
    }
}
