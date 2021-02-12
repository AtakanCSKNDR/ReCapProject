using ReCapCar.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByBrandId(int id);
        Car GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
