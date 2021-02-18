using FluentValidation;
using ReCapCar.Business.Abstract;
using ReCapCar.Business.Constants;
using ReCapCar.Business.ValidationRules.FluentValidation;
using ReCapCar.Core.Aspects.Autofac.Validation;
using ReCapCar.Core.CrossCuttingConcerns.Validation;
using ReCapCar.Core.Utilities.Results.Abstract;
using ReCapCar.Core.Utilities.Results.Concreate;
using ReCapCar.DataAccess.Abstract;
using ReCapCar.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.Business.Concreate
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (_brandDal.GetAll() == null)
            {
                return new ErrorDataResult<List<Brand>>(_brandDal.GetAll(), Messages.NotExist);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll() , Messages.Success);
        }

        public IDataResult<Brand>GetById(int id)
        {
            if (_brandDal.Get(brand => brand.Id == id) == null)
            {
                return new ErrorDataResult<Brand>(_brandDal.Get(brand => brand.Id == id), Messages.NotExist);
            }
            return new SuccessDataResult<Brand>(_brandDal.Get(brand => brand.Id == id) , Messages.Success);
        }

        public IResult Update(Brand brand)
        {
            if (_brandDal.Get(x => x.Id == brand.Id) == null)
            {
                return new ErrorResult(Messages.NotExist);
            }
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
