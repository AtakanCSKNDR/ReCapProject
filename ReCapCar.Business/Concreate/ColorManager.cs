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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            if (_colorDal.GetAll() == null)
            {
                return new ErrorDataResult<List<Color>>(Messages.NotExist);
            }
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll() , Messages.Success);

        }

        public IDataResult<Color> GetById(int id)
        {
            if (_colorDal.Get(color => color.Id == id) == null)
            {
                return new ErrorDataResult<Color>(Messages.NotExist);
            }
            return new SuccessDataResult<Color>(_colorDal.Get(color => color.Id == id) , Messages.Success);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
