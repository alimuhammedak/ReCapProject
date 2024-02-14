using Entities.Abstract;
using System;
using System.Linq;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public int BrandId { get; set; }
        public required string Name { get; set; }
        
    }
}
