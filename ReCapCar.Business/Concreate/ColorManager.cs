using ReCapCar.Business.Abstract;
using ReCapCar.DataAccess.Abstract;
using ReCapCar.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.Business.Concreate
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(color => color.Id == id);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
