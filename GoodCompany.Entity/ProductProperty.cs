using System;
using System.Collections.Generic;
using System.Text;

namespace GoodCompany.Entity
{
    public class ProductProperty : BaseEntity
    {
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string Processor { get; set; }
        public int UsbPorts { get; set; }
        public int RamSlots { get; set; }
        public float ScreenSize { get; set; }

        public int BrandId { get; set; }
        public int ComputerTypeId { get; set; }
    }
}
