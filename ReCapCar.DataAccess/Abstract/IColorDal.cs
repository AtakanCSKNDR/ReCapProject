using ReCapCar.Core.DataAccess;
using ReCapCar.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
    }
}
