using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.Data.Abstract;
using Layer.Entity.Concart;

namespace Layer.Data.Concart.EntityFramework
{
   public class EntityFrameworkStudentClub:EntityFrameworkRepository<Student_Club,StudentContext>,IStudent_Club_DAL
    {
    }
}
