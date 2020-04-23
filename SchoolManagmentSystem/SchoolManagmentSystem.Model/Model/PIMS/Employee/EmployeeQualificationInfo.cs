using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagmentSystem.Model.Model.Employee
{
    public class EmployeeQualificationInfo
    {
        public int Id { set; get; }
        public string DegreeName { set; get; }
        public string InstituteName { set; get; }
        public string GroupOrSubject { set; get; }
        public string ClassOrGrade { set; get; }
        public DateTime PassingYear { set; get; }
        public string BoardOrUniversity { set; get; }
    }
}
