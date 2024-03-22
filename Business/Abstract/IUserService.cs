using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User entity);

        IResult AddRange(IEnumerable<User> users);

        IResult Update(User entity);

        IResult Delete(User entity);

        Task<IDataResult<IEnumerable<User>>> GetAllAsync();

        Task<IDataResult<User>> GetByIdAsync(int id);

    }
}
