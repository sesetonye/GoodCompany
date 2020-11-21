using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodCompany.Web.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }

        public string Processor { get; set; }
        public int UsbPorts { get; set; }
        public int RamSlots { get; set; }
        public float ScreenSize { get; set; }

        public int BrandId { get; set; }
        public int ComputerTypeId { get; set; }

        public int Quantity { get; set; }

        public IEnumerable<SelectListItem> BrandList { get; set; }
        public IEnumerable<SelectListItem> ComputerTypeList { get; set; }
    }
}
