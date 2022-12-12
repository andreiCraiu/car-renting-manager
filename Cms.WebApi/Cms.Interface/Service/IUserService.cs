using Cms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Interface.Service
{
    public interface IUserService
    {
        public UserModel GetUserByEmail(string email);
        public void SaveUser(UserModel userModel);

    }
}
