using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagmentSystem.Model.Model.Others
{
    public class District
    {
        public int id { set; get; }
        public int division_id { set; get; }
        public string name { set; get; }
        public string bn_name { set; get; }
        public string lat { set; get; }
        public string lon { set; get; }
        public string url { set; get; }
    }
}
