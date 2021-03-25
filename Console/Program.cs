using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //CarTest();

            

            
            


            

            

            
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            

            foreach (var car in result.Data)
            {

                System.Console.WriteLine(car.CarBrandName);
                System.Console.WriteLine(car.CarName);
                System.Console.WriteLine(car.Description);
                System.Console.WriteLine(car.ModelYear);
                System.Console.WriteLine(car.CarColorName);
                System.Console.WriteLine(car.DailyPrice + " TL");
                System.Console.WriteLine("-------");

                

            }

            


            


        }


        
    }
}
