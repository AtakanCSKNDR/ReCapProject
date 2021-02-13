using ReCapCar.Business.Concreate;
using ReCapCar.DataAccess.Concreate.EntityFramework;
using ReCapCar.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.ConsoleUI.Controllers
{
    public class ColorsController
    {
        ColorManager _colorManager;
        public ColorsController()
        {
            _colorManager = new ColorManager(new EfColorDal());
        }

        public void GetColors()
        {
            foreach (var item in _colorManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }
        public void GetColorById(int id)
        {
            Color color = _colorManager.GetById(id);
            Console.WriteLine(color.Name);
        }

        public void AddColor(Color color)
        {
            _colorManager.Add(color);
            Console.WriteLine("Color has been added");
        }
        public void UpdateColor(Color color)
        {
            _colorManager.Update(color);
            Console.WriteLine("Color has been updated");
        }
        public void DeleteColor(Color color)
        {
            _colorManager.Delete(color);
            Console.WriteLine("Color has been deleted");
        }
    }
}
