using ReCapCar.Business.Abstract;
using ReCapCar.Business.Constants;
using ReCapCar.Core.Utilities.Results.Abstract;
using ReCapCar.Core.Utilities.Results.Concreate;
using ReCapCar.DataAccess.Abstract;
using ReCapCar.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapCar.Business.Concreate
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        ICarDal _carDal;
        ICustomerDal _customerDal;
        public RentalManager(IRentalDal rentalDal, ICarDal carDal, ICustomerDal customerDal)
        {
            _rentalDal = rentalDal;
            _carDal = carDal;
            _customerDal = customerDal;
        }
        public IResult Add(Rental rental)
        {
            if (_carDal.Get(c => c.Id == rental.CarId) == null && _customerDal.Get(customer => customer.Id == rental.CustomerId) == null)
            {
                return new ErrorResult(Messages.NotExist);
            }
            else if (_rentalDal.Get(r => r.CarId == rental.CarId) != null)
            {
                return new ErrorResult(Messages.CarAlreadyRented);
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<Rental> Get(int id)
        {
            if (_rentalDal.Get(rental => rental.Id == id ) == null)
            {
                return new ErrorDataResult<Rental>(Messages.NotExist);
            }
            return new SuccessDataResult<Rental>(_rentalDal.Get(rental => rental.Id == id));
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (_rentalDal.GetAll() == null)
            {
                return new ErrorDataResult<List<Rental>>(Messages.NotExist);
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult Update(Rental rental)
        {
            if (_carDal.Get(car => car.Id == rental.CarId) == null || _customerDal.Get(customer => customer.Id == rental.CustomerId) == null)
            {
                return new ErrorResult(Messages.NotExist);
            }
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
