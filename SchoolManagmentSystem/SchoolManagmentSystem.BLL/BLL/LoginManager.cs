using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagmentSystem.Model.Model;
using SchoolManagmentSystem.Repository.Repository;

namespace SchoolManagmentSystem.BLL.BLL
{
    public class LoginManager
    {
        LoginRepository _loginRepository = new LoginRepository();

        public bool Add(Login login)
        {
            return _loginRepository.Add(login);
        }
    }
}
