using System;
using System.Linq.Expressions;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {


            //carTest();
            //rentTest(c=> c.carId==1);
            rentTest(c=> c.returnDate == null);
           
           

            /*
            
             * 
             * SQL eklemelerinden sonra WEBAPI eklenecek.
             * 
             */ 
            














        }

        private static void carTest(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails(filter);



            foreach (var car in result.Data)
            {

                System.Console.WriteLine(car.carBrandName);
                System.Console.WriteLine(car.carName);
                System.Console.WriteLine(car.description);
                System.Console.WriteLine(car.modelYear);
                System.Console.WriteLine(car.carColorName);
                System.Console.WriteLine(car.dailyPrice + " TL");
                System.Console.WriteLine("-------");


            }


           











        }

        private static void rentTest(Expression<Func<RentDetailDto, bool>> filter = null)
        {
            RentManager rentManager = new RentManager(new EfRentDal());
            var result = rentManager.GetRentDetails(filter);

            foreach (var rent in result.Data)
            {

                System.Console.WriteLine(rent.rentId);
                System.Console.WriteLine(rent.carName);
                System.Console.WriteLine(rent.carBrandName);
                System.Console.WriteLine(rent.customerName);
                System.Console.WriteLine(rent.returnDate);
            }




        }




    }
}
