using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult AddRange(IEnumerable<User> users)
        {
            _userDal.AddRange(users);
            return new SuccessResult(Messages.UsersAdded);
        }

        public IResult Delete(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<IEnumerable<User>>> GetAllAsync()
        {
            return new SuccessDataResult<IEnumerable<User>>(await _userDal.GetAllAsync());
        }

        public async Task<IDataResult<User>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<User>(await _userDal.GetAsync(user => user.Id == id));
        }

        public IResult Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
