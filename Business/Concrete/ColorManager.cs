using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ColorManager : IColorSevice
{
    public IColorDal _colorDal;

    public ColorManager(IColorDal colorDal)
    {
        _colorDal = colorDal;
    }

    public IResult Add(Color entity)
    {
        _colorDal.Add(entity);
        return new SuccessResult();
    }

    public IResult Delete(Color entity)
    {
        throw new NotImplementedException();
    }

    public Task<IDataResult<IEnumerable<Color>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Color>> GetColorByName()
    {
        throw new NotImplementedException();
    }

    public IResult Update(Color entity)
    {
        throw new NotImplementedException();
    }
}