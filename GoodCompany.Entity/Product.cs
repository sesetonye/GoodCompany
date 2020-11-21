using System;

namespace GoodCompany.Entity
{
    public class Product : BaseEntity
    {

        public Guid ProductId { get; set; }
        public string Name { get; set; }

        public virtual ProductProperty ProductProperty { get; set;}
        public virtual ProductQuantity ProductQuantity {get; set;}
    }
}
