    using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Car: IEntity
    {
        public int CarId{ get; set; }
        public int CarBrandId { get; set; }
        public int CarColorId { get; set; }
        public string CarName { get; set; }
        public string ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description  { get; set; }
        public bool automaticTransmission { get; set; }


    }
}
