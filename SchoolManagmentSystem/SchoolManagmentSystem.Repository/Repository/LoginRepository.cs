using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagmentSystem.Model.Model;
using SchoolManagmentSystem.DatabaseContext.DatabaseContext;
namespace SchoolManagmentSystem.Repository.Repository
{
    public class LoginRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public bool Add(Login login)
        {
            _dbContext.Logins.Add(login);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
