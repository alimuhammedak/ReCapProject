using Business.Abstract;
using Business.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Remove(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public async Task<IDataResult<IEnumerable<RentalDetailDTOs>>> GetRentalDetailsAsync()
        {
            var result = await _rentalDal.GetRentalDetailAsync();
            return new SuccessDataResult<IEnumerable<RentalDetailDTOs>>(result);
        }

        public async Task<IDataResult<IEnumerable<RentalDetailDTOs>>> GetRentalDetailsByCustomerName(string name)
        {
            var result = await _rentalDal.GetRentalDetailAsync(os => os.CustomerFullName.Equals(name));
            return new SuccessDataResult<IEnumerable<RentalDetailDTOs>>(result);
        }

        public async Task<IDataResult<IEnumerable<RentalDetailDTOs>>> GetRentalDetailsByCarName(string carName)
        {
            var result = await _rentalDal.GetRentalDetailAsync(os => os.CarName == carName);
            return new SuccessDataResult<IEnumerable<RentalDetailDTOs>>(result);
        }
    }
}
