using ReCapCar.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.Business.Abstract
{
    public interface IBrandService 
    {
        List<Brand> GetAll();
        Brand GetById(int id);
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
    }
}
