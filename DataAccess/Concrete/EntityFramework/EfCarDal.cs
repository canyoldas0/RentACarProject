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
                              on c.CarBrandId equals b.brandId
                              join co in context.Colors
                              on c.CarColorId equals co.colorId
                             select new CarDetailDto { CarId = c.CarId,
                                 CarBrandName=b.brandName,
                                 BrandId=b.brandId,
                                 CarName=c.CarName,
                                 CarColorName=co.colorName,
                                 CarColorId= co.colorId,
                                 ModelYear=c.ModelYear,
                                 DailyPrice=c.DailyPrice,
                                 Description=c.Description,
                             AutomaticTransmission=c.automaticTransmission};

                return filter == null ? result.ToList(): result.Where(filter).ToList();
                
            }

        
            }

        
        }
    }
    

