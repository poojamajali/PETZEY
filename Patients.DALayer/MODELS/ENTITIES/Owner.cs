using System;
using System.Collections.Generic;

namespace Patients.DALayer.MODELS.ENTITIES
{
    public class Owner
    {
        public long OwnerId { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();
        public DateTime Updatedtime { get; set; }
    }
}
