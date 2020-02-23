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
        [Display(Name = "Dr. Name")]
        [Required(ErrorMessage = "Veterinarian name is required")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Type of animal being served")]
        [Required(ErrorMessage = "Animal type is required")]
        [StringLength(20)]
        public string animalType { get; set; }
        [Display(Name = "Dr. email")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your most frequently used email address")]
        public string email { get; set; }
        [Display(Name = "Dr. phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3{\) |\d{3} -) \d{3} - \d {4}$",
            ErrorMessage = "Phone numbers must be in the format (xxx)-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }
        [Display(Name = "Veterinarian start date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime vetSince { get; set; }
        
        public ICollection<Pet> Pet { get; set; }
    }
}