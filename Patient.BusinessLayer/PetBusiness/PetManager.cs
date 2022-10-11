using DTOLayer;
using Patient.BusinessLayer.INTERFACE;
using Patient.BusinessLayer.MAPPER;
using Patients.DALayer.MODELS.ENTITIES;
using Repository.PetRepo;
using System.Collections.Generic;

namespace Patient.BusinessLayer.MANAGER
{
    public class PetManager : IPetManager
    {
        private readonly IPetRepo repo;
        PetDtoMapper _mapper;
        public PetManager(IPetRepo repo)
        {
            this.repo = repo;
            _mapper = new PetDtoMapper();
        }
        public PetManager()
        {
            repo = new PetRepo();
            _mapper = new PetDtoMapper();
        }
        public bool AddPet(PetDto p)
        {
            Pet _pet = _mapper.mapDto(p);
            if (repo.AddPet(_pet))
                return true;
            return false;
        }

        public bool DeletePetById(long petId)
        {
            if (repo.DeletePetById(petId))
                return true;
            else
                return false;
        }

        public bool EditPet(PetDto pet)
        {
            var _pet = _mapper.mapDto(pet);
            if (repo.EditPet(_pet))
                return true;
            return false;
        }

        public List<PetDto> GetAllPets()
        {
            List<Pet> _pets = repo.GetAllPets();
            List<PetDto> _dtoPets = new List<PetDto>();
            foreach (var item in _pets)
            {
                var dto = _mapper.mapEntity(item);
                _dtoPets.Add(dto);
            }
            return _dtoPets;
        }

        public List<PetDto> GetAllPetsByOwnerID(long ownerId)
        {
            List<Pet> _pets = repo.GetAllPetsByOwnerID(ownerId);
            List<PetDto> _dtoPets = new List<PetDto>();
            foreach (var item in _pets)
            {
                var dto = _mapper.mapEntity(item);
                _dtoPets.Add(dto);
            }
            return _dtoPets;

        }

        public PetDto GetPetById(long id)
        {
            Pet _pet = repo.GetPetById(id);
            var dto = _mapper.mapEntity(_pet);
            return dto;
        }
    }
}
