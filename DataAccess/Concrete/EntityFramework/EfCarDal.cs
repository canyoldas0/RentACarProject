using System;
using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:EfEntityRepositoryBase<Car,DummyContext>, ICarDal

    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto,bool>>filter =null)
        {
            using (DummyContext context = new DummyContext())
            {

                var result = from c in context.Cars
                             join b in context.Brands
                              on c.carBrandId equals b.brandId
                              join co in context.Colors
                              on c.carColorId equals co.colorId
                             select new CarDetailDto { carId = c.carId,
                                 carBrandName=b.brandName,
                                 brandId=b.brandId,
                                 carName=c.carName,
                                 carColorName=co.colorName,
                                 carColorId= co.colorId,
                                 modelYear=c.modelYear,
                                 dailyPrice=c.dailyPrice,
                                 description=c.description,
                             };

                return filter == null ? result.ToList(): result.Where(filter).ToList();
                
            }

        
            }

        
        }
    }
    

