using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SchoolManagmentSystem.Model.Model.Administration;
using SchoolManagmentSystem.DatabaseContext.DatabaseContext;

namespace SchoolManagmentSystem.Repository.Repository.Administration
{
    public class GroupRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public bool Add(Group group)
        {
            _dbContext.Groups.Add(group);
            return _dbContext.SaveChanges() > 0;
        }
        public List<Group> GetAll()
        {
            return _dbContext.Groups.ToList();
        }
        public Group GetById(int id)
        {
            return _dbContext.Groups.FirstOrDefault(c => c.Id == id);
        }
        public bool Update(Group group)
        {
            var aGroup = _dbContext.Groups.FirstOrDefault(c => c.Id == group.Id);
            aGroup.GroupName = group.GroupName;
            return _dbContext.SaveChanges() > 0;
        }
        public bool Delete(Group group)
        {
            Group aGroup = _dbContext.Groups.FirstOrDefault(c => c.Id == group.Id);
            _dbContext.Groups.Remove(aGroup);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
