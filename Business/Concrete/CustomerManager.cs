using Business.Abstract;
using Business.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public async Task<IDataResult<IEnumerable<Customer>>> GetAllAsync()
        {
            var result = await _customerDal.GetAllAsync();
            return new SuccessDataResult<IEnumerable<Customer>>(result);
        }

        public IDataResult<IEnumerable<Customer>> GetCustomerById(int id)
        {
            var result = _customerDal.GetAll(customer => customer.CustomerId == id);
            return new SuccessDataResult<IEnumerable<Customer>>(result);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
