using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentDetailDto: IDto
    {

        public int rentId { get; set; }

        public int carId { get; set; }
        public string carName { get; set; }
        public string carDescription { get; set; }
        public decimal dailyPrice { get; set; }
        public string carColorName { get; set; }
        public string customerName { get; set; }
        public DateTime carModelYear { get; set; }
        public string carBrandName { get; set; }

        public int customerId { get; set; }
        public DateTime rentDate { get; set; }
        public Nullable<DateTime> returnDate { get; set; }



        //Rental, Customer, Car tabloları joinle
    }
}
