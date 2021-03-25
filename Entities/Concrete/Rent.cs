using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rent: IEntity
    {

        public int id { get; set; }
        public int carId { get; set; }
        public int customerId { get; set; }
        public DateTime rentDate { get; set; }
        public Nullable<DateTime>returnDate { get; set; }

    }
}
