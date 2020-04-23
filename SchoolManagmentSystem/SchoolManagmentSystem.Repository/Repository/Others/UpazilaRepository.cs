using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SchoolManagmentSystem.Model.Model.Others;
using SchoolManagmentSystem.DatabaseContext.DatabaseContext;

namespace SchoolManagmentSystem.Repository.Repository.Others
{
    public class UpazilaRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public List<Upazila> GetAll(int id)
        {
            return _dbContext.Upazilas
                .Where(c => c.district_id == id)
                .ToList();
        }
    }
}
