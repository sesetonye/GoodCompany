using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCompany.Entity
{
    public class ProductQuantity : BaseEntity
    {
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
