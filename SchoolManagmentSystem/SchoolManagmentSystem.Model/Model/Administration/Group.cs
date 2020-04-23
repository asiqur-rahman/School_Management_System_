using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagmentSystem.Model.Model.Administration
{
    public class Group
    {
        public int Id { set; get; }
        public string GroupName { set; get; }
        public string EntryBy { set; get; }
        public DateTime EntryDate { set; get; }
    }
}
