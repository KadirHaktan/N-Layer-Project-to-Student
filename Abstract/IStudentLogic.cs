using Layer.Entity.Concart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Business.Abstract
{
   public interface IStudentLogic
   {
       List<Student> GetAll();
     
       void Add(Student student);
       void Update(Student student);
       void Delete(Student student);

       List<Student> GetByStudentID(int ID);
       List<Student> GetByStudentClubID(int ID);


   }
}
