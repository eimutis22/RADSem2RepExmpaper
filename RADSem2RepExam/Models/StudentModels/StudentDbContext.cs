using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RADSem2RepExam.Models.StudentModels
{
    public class StudentDbContext: DbContext
    {
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Student> Students { get; set; }

        public StudentDbContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }
    }
}