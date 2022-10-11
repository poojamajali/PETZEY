using DTOLayer;
using Patient.BusinessLayer.INTERFACE;
using Patient.BusinessLayer.MANAGER;
using System.Collections.Generic;
using System.Web.Http;

namespace Patient.Controllers
{
    public class PetController : ApiController
    {
        private readonly IPetManager petManager = null;
        public PetController(IPetManager petManager)
        {
            this.petManager = petManager;
        }
        public PetController()
        {
            this.petManager = new PetManager();
        }
        [HttpGet]

        public IHttpActionResult GetPets()
        {
            List<PetDto> pets = petManager.GetAllPets();
            return Ok(pets);
        }

        [Route("api/patient/pet/{id}")]
        public IHttpActionResult GetPetById(long id)
        {
            if (petManager.GetPetById(id) != null)
            {
                return Ok(petManager.GetPetById(id));
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPost]
        public IHttpActionResult PostPet(PetDto pet)
        {
            if (petManager.AddPet(pet) && ModelState.IsValid)
                return Ok();
            else return BadRequest();
        }
        [Route("api/patient/allpetsbyid/{id}")]
        public IHttpActionResult GetAllPetsByOwnerId(long id)
        {
            if (petManager.GetAllPetsByOwnerID(id) != null)
            {
                return Ok(petManager.GetAllPetsByOwnerID(id));
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        public IHttpActionResult EditPet(PetDto pet)
        {
            if (petManager.EditPet(pet) && ModelState.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public IHttpActionResult DeletePet(long id)
        {
            if (petManager.DeletePetById(id))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
