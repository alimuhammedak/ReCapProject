using Core.Entities;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public int userId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string FullName => $"{FirstName} {LastName}";

    }
}
