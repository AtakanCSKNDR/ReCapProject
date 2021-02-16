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
    public class CustomerManager : ICustomerService
    {

        ICustomerDal _customerDal;
        IUserDal _userDal;
        public CustomerManager(ICustomerDal customerDal , IUserDal userDal)
        {
            _customerDal = customerDal;
            _userDal = userDal;
        }
        public IResult Add(Customer customer)
        {
            if (_userDal.Get(user => user.Id == customer.UserId) == null)
            {
                return new ErrorResult(Messages.NotExist);
            }
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);

        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
           
        }

        public IDataResult<List<Customer>> GetAll()
        {
            if (_customerDal.GetAll() == null)
            {
                return new ErrorDataResult<List<Customer>>(Messages.NotExist);
            }
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll() , Messages.Success);
        }

        public IDataResult<Customer> GetById(int id)
        {
            if (_customerDal.Get(customer => customer.Id == id) == null)
            {
                return new ErrorDataResult<Customer>(Messages.NotExist);
            }
            return new SuccessDataResult<Customer>(_customerDal.Get(customer => customer.Id == id) , Messages.Success);
        }

        public IResult Update(Customer customer)
        {
            if (_userDal.Get(u => u.Id == customer.UserId) == null)
            {
                return new ErrorResult(Messages.NotExist);
            }
            return new SuccessResult(Messages.CustomerUpdated);
        
        }
    }
}
