using DTOLayer;
using Patient.BusinessLayer.MAPPER;
using Patients.DALayer.MODELS.ENTITIES;
using Repository.OwnerRepo;
using System.Collections.Generic;

namespace Patient.BusinessLayer.OwnerBusiness
{
    public class OwnerManager : IOwnerManager
    {
        private readonly IOwnerRepo repo;
        OwnerDtoMapper _mapper;
        public OwnerManager(IOwnerRepo repo)
        {
            this.repo = repo;
            _mapper = new OwnerDtoMapper();
        }
        public OwnerManager()
        {
            repo = new OwnerRepo();
            _mapper = new OwnerDtoMapper();
        }
        public bool AddOwner(OwnerDto dtoowner)
        {
            var _owner = _mapper.mapDto(dtoowner);
            if (repo.AddOwner(_owner))
                return true;
            return false;
        }

        public bool EditOwner(OwnerDto owner)
        {
            var _owner = _mapper.mapDto(owner);
            if (repo.EditOwner(_owner))
                return true;
            return false;
        }

        public List<OwnerDto> GetAllOwners()
        {
            List<Owner> _owners = repo.GetAllOwners();
            List<OwnerDto> _ownerDtos = new List<OwnerDto>();
            foreach (var item in _owners)
            {
                var _owner = _mapper.mapEntity(item);
                _ownerDtos.Add(_owner);
            }
            return _ownerDtos;
        }

        public OwnerDto GetOwnerById(long id)
        {
            Owner _owner = repo.GetOwnerById(id);
            OwnerDto _ownerDto = _mapper.mapEntity(_owner);
            return _ownerDto;
        }
    }
}
