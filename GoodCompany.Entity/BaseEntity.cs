using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GoodCompany.Entity
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }
}
