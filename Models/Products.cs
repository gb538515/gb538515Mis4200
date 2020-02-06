using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace gb538515Mis4200.Models
{
    public class Products
    {
        [Key]
        public int productID { get; set; }

        public int supplierID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<orderDetail> OrderDetail { get; set; }

    }

    public class orderDetail
    { 


 public int orderdetailID { get; set; }
    public int qtyOrdered { get; set; }
    public decimal price { get; set; }
    // the next two properties link the orderDetail to the Order
    public int orderID { get; set; }
    public virtual Order Order { get; set; }
    // the next two properties link the orderDetail to the Product
    public int productID { get; set; }
    public virtual Products Product { get; set; }
}
}