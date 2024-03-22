using Core.Utilities.Result;
using Entities.DTOs;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);

        IResult Remove(Rental rental);

        IResult Update(Rental rental);

        Task<IDataResult<IEnumerable<RentalDetailDTOs>>> GetRentalDetailsAsync();

        Task<IDataResult<IEnumerable<RentalDetailDTOs>>> GetRentalDetailsByCustomerName(string name);

        Task<IDataResult<IEnumerable<RentalDetailDTOs>>> GetRentalDetailsByCarName(string carName);

    }
}

