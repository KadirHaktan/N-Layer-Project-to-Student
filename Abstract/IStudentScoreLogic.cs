using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.Entity.Concart;

namespace Layer.Business.Abstract
{
   public interface IStudentScoreLogic
   {
       List<Student_Score> GetAll();

       List<Student_Score> GetByStudentID(int ID);

       void Add(Student_Score score);

       void Delete(Student_Score score);

       void Update(Student_Score score);
   }
}
