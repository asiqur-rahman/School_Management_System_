using System;
using System.Collections.Generic;
using System.Text;
using SchoolManagmentSystem.Model.Model.Student;
using SchoolManagmentSystem.Repository.Repository.PIMS;

namespace SchoolManagmentSystem.BLL.BLL.PIMS
{
    public class StudentInfoManager
    {
        StudentInfoRepository _studentInfoRepository = new StudentInfoRepository();
        public bool Add(StudentInfo studentInfo)
        {
            return _studentInfoRepository.Add(studentInfo);
        }
    }
}
