using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using SchoolManagmentSystem.Model.Model;
using SchoolManagmentSystem.Model.Model.Administration;
using SchoolManagmentSystem.Model.Model.Student;
using SchoolManagmentSystem.Model.Model.Others;

namespace SchoolManagmentSystem.DatabaseContext.DatabaseContext
{
    public class ProjectDbContext : DbContext
    {
            public ProjectDbContext()
            {
                Configuration.LazyLoadingEnabled = false; //Disable Lazy loading
            }

            public DbSet<Login> Logins { get; set; }

            //Administration
            public DbSet<Shift> Shifts { set; get; }
            public DbSet<Class> Classes { set; get; }
            public DbSet<Section> Sections { set; get; }
            public DbSet<Group> Groups { set; get; }
            public DbSet<Subject> Subjects { set; get; }

            public DbSet<StudentInfo> StudentInfos { set; get; }
            public DbSet<StudentDetailsInfo> StudentDetailsInfos { set; get; }

            public DbSet<Division> Divisions { set; get; }
            public DbSet<District> Districts { set; get; }
            public DbSet<Upazila> Upazilas { set; get; }

    }
    
}
