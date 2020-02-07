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

        public string petName { get; set; }
        public string animalType { get; set; }
        public string healthIssue { get; set; }
        public string ownerPhone { get; set; }
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