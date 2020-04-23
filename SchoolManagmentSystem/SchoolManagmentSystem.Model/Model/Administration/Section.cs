using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagmentSystem.Model.Model.Administration
{
    public class Section
    {
        public int Id { set; get; }
        public string SectionCode { set; get; }
        public string SectionName { set; get; }
        public string EntryBy { set; get; }
        public DateTime EntryDate { set; get; }
        public int ShiftId { set; get; }
        public string ShiftName { set; get; }
        public int ClassId { set; get; }
        public string ClassName { set; get; }
    }
}
