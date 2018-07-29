using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.Entity.Concart;

namespace Layer.Business.Abstract
{
   public interface IStudentClubLogic
   {
       List<Student_Club> GetAll();
   }
}
