using DTOLayer;
using Patients.DALayer.MODELS.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Patient.BusinessLayer.MAPPER
{
    public class OwnerDtoMapper
    {
        public Owner mapDto(OwnerDto dtoowner)
        {
            var _owner = new Owner
            {
                OwnerId = dtoowner.OwnerId,
                Name = dtoowner.Name,
                MobileNo = dtoowner.MobileNo,
                Location = dtoowner.Location,
                ImageUrl = dtoowner.ImageUrl,
                Pets = dtoowner.Pets,
                Updatedtime = DateTime.Now
            };
            return _owner;
        }

        public OwnerDto mapEntity(Owner owner)
        {
            var _owner = new OwnerDto
            {
                OwnerId = owner.OwnerId,
                Name = owner.Name,
                MobileNo = owner.MobileNo,
                Location = owner.Location,
                ImageUrl = owner.ImageUrl,
                Pets = owner.Pets
            };
            return _owner;
        }
    }
}
