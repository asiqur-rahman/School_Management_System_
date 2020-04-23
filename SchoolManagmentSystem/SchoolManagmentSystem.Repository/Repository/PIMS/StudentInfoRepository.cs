using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagmentSystem.Model.Model.Student;
using SchoolManagmentSystem.DatabaseContext.DatabaseContext;

namespace SchoolManagmentSystem.Repository.Repository.PIMS
{
    public class StudentInfoRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public bool Add(StudentInfo studentInfo)
        {
            _dbContext.StudentInfos.Add(studentInfo);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
