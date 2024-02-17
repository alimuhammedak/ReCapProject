using Entities.Concrete;

namespace Business.Abstract;

public interface IColorSevice
{
    Task<IEnumerable<Color>> GetColorByName();
}