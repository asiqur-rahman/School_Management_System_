using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SchoolManagmentSystem.Model.Model.Administration;
using SchoolManagmentSystem.DatabaseContext.DatabaseContext;

namespace SchoolManagmentSystem.Repository.Repository.Administration
{
    public class SectionRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public bool Add(Section section)
        {
            _dbContext.Sections.Add(section);
            return _dbContext.SaveChanges() > 0;
        }
        public List<Section> GetAll()
        {
            return _dbContext.Sections.ToList();
        }
        public Section GetById(int id)
        {
            return _dbContext.Sections.FirstOrDefault(c => c.Id == id);
        }
        public bool Update(Section section)
        {
            var aSection = _dbContext.Sections.FirstOrDefault(c => c.Id == section.Id);
            aSection.SectionName = section.SectionName;
            return _dbContext.SaveChanges() > 0;
        }
        public bool Delete(Section section)
        {
            Section aSection = _dbContext.Sections.FirstOrDefault(c => c.Id == section.Id);
            _dbContext.Sections.Remove(aSection);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
