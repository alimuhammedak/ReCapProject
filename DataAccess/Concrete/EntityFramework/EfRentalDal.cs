using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public async Task<IEnumerable<RentalDetailDTOs>> GetRentalDetailAsync(Expression<Func<RentalDetailDTOs, bool>>? filter = null)
        {
            //using var context = new ReCapContext();

            //var rentalDetailDTOs = await context.Rental
            //    .Include(r => r) // Car entity should be included, not the CarId
            //    .Include(r => r.Customer) // Customer entity should be included, not the CustomerId
            //    .Select(r => new RentalDetailDTOs
            //    {
            //        CarName = r.Car.Description, // Assuming Car has a Description property
            //        CustomerFullName = r.Customer.f, // Assuming User has a UserName or FullName property
            //        RentalId = r.RentalId // Assuming Rental has an Id property
            //    })
            //    .ToListAsync();

            //// Apply the filter if it's not null
            //if (filter != null)
            //{
            //    rentalDetailDTOs = rentalDetailDTOs.Where(filter.Compile()).ToList();
            //}

            //return rentalDetailDTOs;
            throw new NotImplementedException();
        }


    }
}
