using Patients.DALayer.MODELS.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class PetDto
    {
        public long PetId { get; set; }
        public GenderType Gender { get; set; }
        public string PetName { get; set; }
        public string BloodGroup { get; set; }
        public DateTime DOB { get; set; }
        public List<Allergy> Allergies { get; set; }
        public SpeciesType Species { get; set; }
        public string Breed { get; set; }
        public string ImageUrl { get; set; }
    }
}
