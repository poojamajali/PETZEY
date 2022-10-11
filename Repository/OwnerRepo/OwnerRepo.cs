using Patients.DALayer.MODELS.DATA;
using Patients.DALayer.MODELS.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.OwnerRepo
{
    public class OwnerRepo : IOwnerRepo
    {
        DbContextPatients db = new DbContextPatients();
        public bool AddOwner(Owner owner)
        {
            db.Owners.Add(owner);
            db.SaveChanges();
            return true;
        }

        public bool EditOwner(Owner owner)
        {
            var ownernew = db.Owners.Find(owner.OwnerId);
            if (ownernew != null)
            {
                db.Entry(owner).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Owner> GetAllOwners()
        {
            return db.Owners.ToList();
        }



        public Owner GetOwnerById(long id)
        {
            return db.Owners.Find(id);
        }
    }

}
