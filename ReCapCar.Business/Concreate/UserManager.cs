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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);

        }

        public IDataResult<List<User>> GetAll()
        {
            if (_userDal.GetAll() == null)
            {
                return new ErrorDataResult<List<User>>(Messages.NotExist);
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll() , Messages.Success);
        }

        public IDataResult<User> GetById(int id)
        {
            if (_userDal.Get(u => u.Id == id ) == null )
            {
                return new ErrorDataResult<User>(Messages.NotExist);
            }
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id) , Messages.Success);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
