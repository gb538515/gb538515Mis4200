using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace gb538515Mis4200.Models
{
    public class Pet
    {
        [Key]

        public int petID { get; set; }
        [Display(Name = "What is your pet's name")]
        [Required(ErrorMessage = "Pet name is required")]
        [StringLength(20)]
        public string petName { get; set; }
        [Display(Name = "What type of animal is your pet?")]
        [Required(ErrorMessage = "Animal type is required")]
        [StringLength(20)]
        public string animalType { get; set; }
        [Display(Name = "Why are you visiting us today?")]
        [Required(ErrorMessage = "Description needed")]
        [StringLength(20)]
        public string healthIssue { get; set; }
        [Display(Name = "Owner phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3{\) |\d{3} -) \d{3} - \d {4}$",
            ErrorMessage = "Phone numbers must be in the format (xxx)-xxxx or xxx-xxx-xxxx")]

        public string ownerPhone { get; set; }
        [Display(Name = "Date of your appointment")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime visitDate { get; set; }
        
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<petDetail> petDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int vetID { get; set; }
        public virtual Vet Vet { get; set; }
    }
}