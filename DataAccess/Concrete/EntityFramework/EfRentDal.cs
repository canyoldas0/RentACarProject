using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentDal : EfEntityRepositoryBase<Rent, DummyContext>, IRentDal
    {
        public List<RentDetailDto> GetRentDetails(Expression<Func<RentDetailDto, bool>> filter = null)
        {
            using (DummyContext context = new DummyContext())

            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.carId equals c.carId
                             join co in context.Colors
                             on c.carColorId equals co.colorId
                             join cus in context.Customers
                             on r.customerId equals cus.customerId
                             join b in context.Brands
                             on c.carBrandId equals b.brandId
                             select new RentDetailDto
                             {
                                 rentId = r.id,
                                 carId = r.carId,
                                 carName = c.carName,
                                 carDescription = c.description,
                                 dailyPrice = c.dailyPrice,
                                 carColorName = co.colorName,
                                 customerName = cus.companyName,
                                 carModelYear = c.modelYear,
                                 customerId = r.customerId,
                                 rentDate = r.rentDate,
                                 carBrandName = b.brandName,
                                 returnDate = r.returnDate 
                                 //Return date null ise DTo ya eklenemiyor=???? solved>>> Nullable<DateTime>

                                 


                             };


                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
            
        }


        //TABLOLARI JOIN'LE
    }
}
