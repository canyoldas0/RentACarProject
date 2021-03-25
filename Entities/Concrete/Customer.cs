using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer: IEntity
    {

        public int customerId { get; set; }
        public String companyName { get; set; }
    }
}
