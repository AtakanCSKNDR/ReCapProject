using ReCapCar.Core.DataAccess.EntityFramework;
using ReCapCar.DataAccess.Abstract;
using ReCapCar.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.DataAccess.Concreate.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, ReCapCarContext>, IBrandDal
    {
    }
}
