using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SchoolManagmentSystem.Model.Model.Others;
using SchoolManagmentSystem.DatabaseContext.DatabaseContext;

namespace SchoolManagmentSystem.Repository.Repository.Others
{
    public class DistrictRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public List<District> GetAll(int id)
        {
            return _dbContext.Districts
                .Where(c => c.division_id == id)
                .ToList();
        }
    }
}
