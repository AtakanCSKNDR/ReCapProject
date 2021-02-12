using ReCapCar.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int id);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
