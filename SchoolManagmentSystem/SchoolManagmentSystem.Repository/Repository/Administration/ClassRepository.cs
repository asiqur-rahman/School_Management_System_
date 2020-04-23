using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SchoolManagmentSystem.Model.Model.Administration;
using SchoolManagmentSystem.DatabaseContext.DatabaseContext;

namespace SchoolManagmentSystem.Repository.Repository.Administration
{
    public class ClassRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public bool Add(Class clas)
        {
            _dbContext.Classes.Add(clas);
            return _dbContext.SaveChanges() > 0;
        }
        public List<Class> GetAll()
        {
            return _dbContext.Classes.ToList();
        }
        public Class GetById(int id)
        {
            return _dbContext.Classes.FirstOrDefault(c => c.Id == id);
        }
        public bool Update(Class clas)
        {
            var cClass = _dbContext.Classes.FirstOrDefault(c => c.Id == clas.Id);
            cClass.ClassName = clas.ClassName;
            cClass.ClassShortName = clas.ClassShortName;
            return _dbContext.SaveChanges() > 0;
        }
        public bool Delete(Class clas)
        {
            Class aClass = _dbContext.Classes.FirstOrDefault(c => c.Id == clas.Id);
            _dbContext.Classes.Remove(aClass);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
