using Cms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Interface.Repository
{
    public interface IUserRepository
    {
        public UserModel GetUserByEmail(string email);
        public void SaveUser(UserModel userModel);
    }
}
