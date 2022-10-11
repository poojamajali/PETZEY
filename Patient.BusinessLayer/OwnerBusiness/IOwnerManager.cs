using DTOLayer;
using System.Collections.Generic;

namespace Patient.BusinessLayer.OwnerBusiness
{
    public interface IOwnerManager
    {
        List<OwnerDto> GetAllOwners();
        bool AddOwner(OwnerDto owner);
        OwnerDto GetOwnerById(long id);
        bool EditOwner(OwnerDto owner);
    }
}
