using ReCapCar.Business.Abstract;
using ReCapCar.Business.Constants;
using ReCapCar.Core.Utilities.Results.Abstract;
using ReCapCar.Core.Utilities.Results.Concreate;
using ReCapCar.DataAccess.Abstract;
using ReCapCar.Entities.Concreate;
using ReCapCar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReCapCar.Business.Concreate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        IBrandDal _brandDal;
        IColorDal _colorDal;

        public CarManager(ICarDal carDal, IBrandDal brandDal, IColorDal colorDal)
        {
            _carDal = carDal;
            _brandDal = brandDal;
            _colorDal = colorDal;
        }
        public IResult Add(Car car)
        {
            if (_brandDal.Get(brand => brand.Id == car.BrandId) == null && _colorDal.Get(color => color.Id == car.ColorId) == null)
            {
                return new ErrorResult(Messages.BrandOrColorNotExist);
            }
            else if (car.DailyPrice < 0)
            {
                return new ErrorResult(Messages.DailyPriceMustBeGreaterThanZero);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (_carDal.GetAll() == null)
            {
                return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.NotExist);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll() , Messages.Success);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            if (_carDal.Get(car => car.BrandId == id) == null)
            {
                return new ErrorDataResult<List<Car>>(_carDal.GetAll(car => car.BrandId == id), Messages.NotExist);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(car => car.BrandId == id),  Messages.Success);
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            if (_carDal.Get(car => car.ColorId == id) == null)
            {
                return new ErrorDataResult<List<Car>>(_carDal.GetAll(car => car.ColorId == id), Messages.NotExist);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(car => car.ColorId == id) , Messages.Success);
        }

        public IDataResult<Car> GetById(int id)
        {
            if (_carDal.Get(car => car.Id == id) == null)
            {
                return new ErrorDataResult<Car>(_carDal.Get(car => car.Id == id), Messages.NotExist);
            }
            return new SuccessDataResult<Car>(_carDal.Get(car => car.Id == id) , Messages.Success);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (_carDal.GetCarDetails() == null)
            {
                return new ErrorDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.NotExist);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.Success);
        }

        public IResult Update(Car car)
        {
            if (_brandDal.Get(brand => brand.Id == car.BrandId) == null && _colorDal.Get(color => color.Id == car.ColorId) == null)
            {
                return new ErrorResult(Messages.BrandOrColorNotExist);
            }
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
