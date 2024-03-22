using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IDataResult<IEnumerable<Customer>> GetCustomerById(int id);
        Task<IDataResult<IEnumerable<Customer>>> GetAllAsync();
    }
}
