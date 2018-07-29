using Layer.Entity.Concart;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Data.Concart.EntityFramework
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Student_Club> Clubs { get; set; }
        public DbSet<Student_Score> Scores { get; set; }
    }
}
