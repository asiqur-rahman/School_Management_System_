using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagmentSystem.Model.Model.Student
{
    public class StudentInfo
    {
        public int Id { set; get; }
        public int DetailsInfoId { set; get; }
        public StudentDetailsInfo DetailsInfo { set; get; }
        public string NameEnglish { set; get; }
        public string NameBengali { set; get; }
        public DateTime DateOfBirth { set; get; }
        public string Nationality { set; get; }
        public string Gender { set; get; }
        public string Religion { set; get; }
        public string PresentAddress { set; get; }
        public string PresentPO { set; get; }
        public string PresentPS { set; get; }
        public string PresentDistrict { set; get; }
        public string PresentPhone { set; get; }
        public string PermanentAddress { set; get; }
        public string PermanentPO { set; get; }
        public string PermanentPS { set; get; }
        public string PermanentDistrict { set; get; }
        public string PermanentPhone { set; get; }
        public string GuardianName { set; get; }
        public string GuardianAddress { set; get; }
        public string Active { set; get; }
        public string UpdateBy { set; get; }
        public DateTime UpdateDate { set; get; }
    }
}
