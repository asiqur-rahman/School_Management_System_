using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagmentSystem.Model.Model.Administration
{
    public class Subject
    {
        public int Id { set; get; }
        public string SubjectCode { set; get; }
        public string SubjectName { set; get; }
        public string SubjectType { set; get; }
        public string EntryBy { set; get; }
        public DateTime EntryDate { set; get; }
    }
}
