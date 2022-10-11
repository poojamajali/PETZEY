using Patients.DALayer.MODELS.DATA;
using Patients.DALayer.MODELS.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.ModelBinding;

namespace Repository.PetRepo
{
    public class PetRepo : IPetRepo
    {
        DbContextPatients db = new DbContextPatients();
        public bool AddPet(Pet pet)
        {
            db.Pets.Add(pet);
            db.SaveChanges();
            return true;
        }

        public bool DeletePetById(long petId)
        {
            var pet = db.Pets.Find(petId);
            if (pet != null)
            {
                db.Pets.Remove(pet);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EditPet(Pet pet)
        {
            var petnew = db.Pets.Find(pet.PetId);
            if(petnew != null)
            {
                db.Entry(pet).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;         
        }     

        public List<Pet> GetAllPets()
        {
            return db.Pets.ToList();
        }

        public List<Pet> GetAllPetsByOwnerID(long ownerId)
        {
            throw new NotImplementedException();
        }

        public bool GetPetById(long id)
        {
            throw new NotImplementedException();
        }
    }

}
