using ReCapCar.Business.Concreate;
using ReCapCar.DataAccess.Concreate.EntityFramework;
using System;

namespace ReCapCar.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetCar();
            //GetBrands();
            GetColors();
        }

        private static void GetColors()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void GetBrands()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void GetCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine(item.Id);
            }
        }
    }
}
