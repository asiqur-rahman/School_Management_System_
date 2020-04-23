using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagmentSystem.Model.Model.Administration
{
    public class Class
    {
        public int Id { set; get; }
        public string ClassName { set; get; }
        public string ClassShortName { set; get; }
        public string EntryBy { set; get; }
        public DateTime EntryDate { set; get; }
    }
}
