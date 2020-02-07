using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gb538515Mis4200.Models
{
    public class Visit
    {
        public int visitID { get; set; }
        public string description { get; set; }
        public decimal visitCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<petDetail> petDetail { get; set; }
    }
    public class petDetail
    {
        public int petdetailID { get; set; }
        public int numberVisits { get; set; }
        public decimal visitPrice { get; set; }

        public string medicineOrdered { get; set; }

        public string ownerEmail { get; set; }
        // the next two properties link the orderDetail to the Order
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }
        // the next two properties link the orderDetail to the Product
        public int visitID { get; set; }
        public virtual Visit Visit { get; set; }
    }
}