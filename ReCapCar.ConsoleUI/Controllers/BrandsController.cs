using ReCapCar.Business.Concreate;
using ReCapCar.DataAccess.Concreate.EntityFramework;
using ReCapCar.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.ConsoleUI.Controllers
{
    public class BrandsController
    {
        BrandManager _brandManager;
        public BrandsController()
        {
            _brandManager = new BrandManager(new EfBrandDal());
        }
        public void GetBrands()
        {
            foreach (var item in _brandManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
        }
        public void GetBrandById(int id)
        {
            Brand brand = _brandManager.GetById(id);
            Console.WriteLine(brand.Name);
        }
        public void AddBrand(Brand brand)
        {
            _brandManager.Add(brand);
            Console.WriteLine("Brand has been added");
        }
        public void DeleteBrand(Brand brand)
        {
            _brandManager.Delete(brand);
            Console.WriteLine("Brand has been deleted");
        }
        public void UpdateBrand(Brand brand)
        {
            _brandManager.Update(brand);
            Console.WriteLine("Brand has been updated");
        }
    }
}
