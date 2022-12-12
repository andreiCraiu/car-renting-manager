using Cms.DataAcces.Data;
using Cms.Interface.Repository;
using Cms.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.DataAcces.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<UserModel> userManager;
        public UserRepository(ApplicationDbContext context, UserManager<UserModel> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }
        public UserModel GetUserByEmail(string email)
        {
            var user = context.ApplicationUsers.FirstOrDefault(x => x.Email == email);
            return user;
        }

        async public void SaveUser(UserModel userModel)
        {
            await context.ApplicationUsers.AddAsync(userModel);
            context.SaveChanges();
            //await userManager.CreateAsync(userModel, userModel.PasswordHash);
        }
    }
}
