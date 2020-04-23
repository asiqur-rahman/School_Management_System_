using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagmentSystem.Model.Model.Employee
{
    public class EmployeeInfo
    {
        public int Id { set; get; }
        public string EmployeeId { set; get; }
        public int Designation { set; get; }
        public string QualificationInfoId { set; get; }
        public EmployeeQualificationInfo QualificationInfo { set; get; }

        public string EmployeeName { set; get; }
        public string FathersName { set; get; }
        public string MothersName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public DateTime DateOfJoin { set; get; }
        public string Nationality { set; get; }
        public string Gender { set; get; }
        public string Religion { set; get; }
        public int YearOfExperience { set; get; }
        public string MaritalStatus { set; get; }
        public string PresentAddress { set; get; }
        public string PresentPO { set; get; }
        public string PresentPS { set; get; }
        public string PresentDistrict { set; get; }
        public string PresentPhone { set; get; }
        public string Email { set; get; }
        public string PermanentAddress { set; get; }
        public string PermanentPO { set; get; }
        public string PermanentPS { set; get; }
        public string PermanentDistrict { set; get; }
        public string PermanentPhone { set; get; }
        public string EmployeeType { set; get; }
        public string EntryBy { set; get; }
        public string UpdateBy { set; get; }
        public DateTime EntryDate { set; get; }
        public DateTime UpdateDate { set; get; }
    }
}
