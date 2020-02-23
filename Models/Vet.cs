using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace gb538515Mis4200.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        public string lastName { get; set; }
        [Display(Name = "Dr. Name")]
        public string animalType { get; set; }
        [Display(Name = "Name of pet being served")]
        public string email { get; set; }
        [Display(Name = "Dr. email")]
        public string phone { get; set; }
        [Display(Name = "Dr. phone number")]
        public DateTime vetSince { get; set; }
        [Display(Name = "Employed start date")]
        public ICollection<Pet> Pet { get; set; }
    }
}