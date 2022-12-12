using Cms.Interface.Repository;
using Cms.Interface.Service;
using Cms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Service.Impl
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public UserModel GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public void SaveUser(UserModel userModel)
        {
            userRepository.SaveUser(userModel);
        }
    }
}
