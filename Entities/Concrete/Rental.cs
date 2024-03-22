using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }

        [Range(typeof(DateTime), "1/1/1900", "6/6/2079")]
        public DateTime RentDate { get; set; }

        [Range(typeof(DateTime), "1/1/1900", "6/6/2079")]
        public DateTime? ReturnDate { get; set; }

    }
}
