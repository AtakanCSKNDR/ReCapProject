using ReCapCar.Business.Concreate;
using ReCapCar.DataAccess.Concreate.EntityFramework;
using ReCapCar.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.ConsoleUI.Controllers
{
    public class CarsController
    {
        CarManager _carManager;
        public CarsController()
        {
            _carManager = new CarManager(new EfCarDal());
        }
        public void GetCar()
        {
            foreach (var item in _carManager.GetAll())
            {
                Console.WriteLine(item.Id);
            }
        }
        public void GetCarById(int id)
        {
            Car car = _carManager.GetById(id);
            Console.WriteLine(car.Id);
        }
        public void GetCarByBrandId(int id)
        {
            foreach (var item in _carManager.GetAllByBrandId(id))
            {
                Console.WriteLine(item.Id);
            }
        }
        public void GetCarByColorId(int id)
        {

            foreach (var item in _carManager.GetAllByColorId(id))
            {
                Console.WriteLine(item.Id);
            }
        }
        public void AddCar(Car car)
        {
            _carManager.Add(car);
            Console.WriteLine("Car has been added");
        }
        public void DeleteCar(Car car)
        {
            _carManager.Delete(car);
            Console.WriteLine("Car has been deleted");
        }
        public void UpdateCar(Car car)
        {
            _carManager.Update(car);
            Console.WriteLine("Car has been updated");
        }
        public void GetCarDetails()
        {
            foreach (var item in _carManager.GetCarDetails())
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.BrandName);
                Console.WriteLine(item.ColorName);
                Console.WriteLine(item.DailyPrice);
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
