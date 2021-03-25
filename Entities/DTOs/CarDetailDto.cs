using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarBrandName { get; set; }
        public int BrandId { get; set; }
        public string CarColorName { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int  CarColorId { get; set; }
        public bool AutomaticTransmission { get; set; }



    }
}
