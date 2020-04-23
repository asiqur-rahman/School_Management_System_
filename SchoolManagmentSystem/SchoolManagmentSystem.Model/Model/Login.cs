using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagmentSystem.Model.Model
{
    public class Login
    {
        public int Id { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string UserType { set; get; }
        public int IsActive { set; get; }
        public string EntryBy { set; get; }
    }
}
