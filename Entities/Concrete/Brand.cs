using Entities.Abstract;
using System;
using System.Linq;

namespace Entities.Concrete
{
    internal class Brand : IEntity
    {
        public int BrandId { get; set; }
        public required string BrandName { get; set; }
        
    }
}
