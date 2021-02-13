using ReCapCar.Business.Concreate;
using ReCapCar.ConsoleUI.Controllers;
using ReCapCar.DataAccess.Concreate.EntityFramework;
using ReCapCar.Entities.Concreate;
using System;

namespace ReCapCar.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarsController carsController = new CarsController();
            carsController.GetCarDetails();

            //BrandsController brandsController = new BrandsController();

            //brandsController.GetBrands();
        }
    }
}
