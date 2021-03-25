using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int carId { get; set; }
        public string carName { get; set; }
        public string carBrandName { get; set; }
        public int brandId { get; set; }
        public string carColorName { get; set; }
        public DateTime modelYear { get; set; }
        public decimal dailyPrice { get; set; }
        public string description { get; set; }
        public int  carColorId { get; set; }
        


    }
}
