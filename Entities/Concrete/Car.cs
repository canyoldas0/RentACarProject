    using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Car: IEntity
    {
        public int carId{ get; set; }
        public int carBrandId { get; set; }
        public int carColorId { get; set; }
        public string carName { get; set; }
        public DateTime modelYear { get; set; }
        public decimal dailyPrice { get; set; }
        public string description  { get; set; }
        


    }
}
