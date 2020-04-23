using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SchoolManagmentSystem.Model.Model.Others;
using SchoolManagmentSystem.DatabaseContext.DatabaseContext;

namespace SchoolManagmentSystem.Repository.Repository.Others
{
    public class DivisionRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public List<Division> GetAll()
        {
            return _dbContext.Divisions.ToList();
        }
    }
}
