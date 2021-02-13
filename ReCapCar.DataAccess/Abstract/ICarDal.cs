using ReCapCar.Core.DataAccess;
using ReCapCar.Entities.Concreate;
using ReCapCar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
