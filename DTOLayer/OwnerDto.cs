using Patients.DALayer.MODELS.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer
{
    public class OwnerDto
    {
        public long OwnerId { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();
    }
}
