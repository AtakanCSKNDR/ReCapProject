using ReCapCar.Core.DataAccess.EntityFramework;
using ReCapCar.DataAccess.Abstract;
using ReCapCar.Entities.Concreate;
using ReCapCar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReCapCar.DataAccess.Concreate.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapCarContext context = new ReCapCarContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BrandId equals brand.Id
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             select new CarDetailDto
                             {
                                 BrandName = brand.Name,
                                 Id = car.Id,
                                 DailyPrice = car.DailyPrice,
                                 ColorName = color.Name,
                             };
                return result.ToList();
            }
        }
    }
}
