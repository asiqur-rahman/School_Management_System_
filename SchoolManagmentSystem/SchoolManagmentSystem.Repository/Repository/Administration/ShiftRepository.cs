using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SchoolManagmentSystem.Model.Model.Administration;
using SchoolManagmentSystem.DatabaseContext.DatabaseContext;

namespace SchoolManagmentSystem.Repository.Repository.Administration
{
    public class ShiftRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public bool Add(Shift shift)
        {
            _dbContext.Shifts.Add(shift);
            return _dbContext.SaveChanges() > 0;
        }
        public List<Shift> GetAll()
        {
            return _dbContext.Shifts.ToList();
        }
        public Shift GetById(int id)
        {
            return _dbContext.Shifts.FirstOrDefault(c => c.Id == id);
        }
        public bool Update(Shift shift)
        {
            var aShift = _dbContext.Shifts.FirstOrDefault(c => c.Id == shift.Id);
            aShift.ShiftName = shift.ShiftName;
            return _dbContext.SaveChanges() > 0;
        }
        public bool Delete(Shift shift)
        {
            Shift aShift = _dbContext.Shifts.FirstOrDefault(c => c.Id == shift.Id);
            _dbContext.Shifts.Remove(aShift);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
