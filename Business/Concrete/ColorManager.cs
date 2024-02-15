using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorSevice
    {
        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Color> entites)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Color>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Color GetCarById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Color>> GetColorByName()
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
