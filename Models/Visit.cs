using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace gb538515Mis4200.Models
{
    public class Visit
    {
        public int visitID { get; set; }
        [Display(Name = "Description of visit")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(140)]
        public string description { get; set; }
        [Display(Name = "Appointment Cost")]
        [DataType(DataType.Currency)]
        public decimal visitCost { get; set; }
        [Display(Name = "Paw exam results")]
        [Required(ErrorMessage = "Results required")]
        [StringLength(20)]
        public string pawExamination { get; set; }
        [Display(Name = "Fur exam results")]
        [Required(ErrorMessage = "Results required")]
        [StringLength(20)]
        public string furHealth { get; set; }

        [Display(Name = "Pet heart rate")]
        [Required(ErrorMessage = "Results required")]
        [StringLength(20)]
        public string heartRate { get; set; }
        
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<petDetail> petDetail { get; set; }
    }
    public class petDetail
    {
        public int petdetailID { get; set; }
        [Display(Name = "Number of visits")]
        [Required(ErrorMessage = "Number required")]
        public int numberVisits { get; set; }
        [Display(Name = "Accumulated charges")]
        [DataType(DataType.Currency)]
        public decimal accumulatedBill { get; set; }
        [Display(Name = "Prescribed Medication")]
        [Required(ErrorMessage = "Required informatin (If none put none")]

        public string medicineOrdered { get; set; }

        [Display(Name = "Owner email")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your most frequently used email address")]
        public string ownerEmail { get; set; }
      
        // the next two properties link the orderDetail to the Order
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }
        // the next two properties link the orderDetail to the Product
        public int visitID { get; set; }
        public virtual Visit Visit { get; set; }
    }
}