using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gb538515Mis4200.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        public string lastName { get; set; }
        public string animalType { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime vetSince { get; set; }

        public ICollection<Pet> Pet { get; set; }
    }
}