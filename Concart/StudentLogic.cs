using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.Business.Abstract;
using Layer.Business.Tools.ValidationTools.Fluent_Validation_Tool;
using Layer.Business.Validation.FlueValidation;
using Layer.Entity.Concart;
using Layer.Data.Abstract;

namespace Layer.Business.Concart
{
    class StudentLogic : IStudentLogic
    {
        private IStudentDAL dal;

        public StudentLogic(IStudentDAL dal)
        {
            this.dal = dal;
        }


        public void Add(Student student)
        {
           
           dal.Add(student);
        }

        public void Delete(Student student)
        {
            try
            {
                dal.Delete(student);
            }

            catch
            {
                throw new Exception("Delete can not complete");
            }
        }

        public List<Student> GetAll()
        {

            return dal.GetAll();
        }

        public List<Student> GetByStudentClubID(int ID)
        {
            return dal.GetAll(p => p.ID == ID);
        }

        public List<Student> GetByStudentID(int ID)
        {
            return dal.GetAll(p => p.ClubID == ID);
        }

        public void Update(Student student)
        {
            
            dal.Update(student);
        }
    }
}
