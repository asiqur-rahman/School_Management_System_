using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SchoolManagmentSystem.Model.Model.Administration;
using SchoolManagmentSystem.DatabaseContext.DatabaseContext;

namespace SchoolManagmentSystem.Repository.Repository.Administration
{
    public class SubjectRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public bool Add(Subject subject)
        {
            _dbContext.Subjects.Add(subject);
            return _dbContext.SaveChanges() > 0;
        }
        public List<Subject> GetAll()
        {
            return _dbContext.Subjects.ToList();
        }
        public Subject GetById(int id)
        {
            return _dbContext.Subjects.FirstOrDefault(c => c.Id == id);
        }
        public bool Update(Subject subject)
        {
            var cSubject = _dbContext.Subjects.FirstOrDefault(c => c.Id == subject.Id);
            cSubject.SubjectName = subject.SubjectName;
            cSubject.SubjectCode = subject.SubjectCode;
            cSubject.SubjectType = subject.SubjectType;
            cSubject.EntryDate = subject.EntryDate;
            return _dbContext.SaveChanges() > 0;
        }
        public bool Delete(Subject subject)
        {
            Subject aSubject = _dbContext.Subjects.FirstOrDefault(c => c.Id == subject.Id);
            _dbContext.Subjects.Remove(aSubject);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
