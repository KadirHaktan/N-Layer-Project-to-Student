using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.Business.Abstract;
using Layer.Business.Tools.ValidationTools.Fluent_Validation_Tool;
using Layer.Business.Validation.FlueValidation;
using Layer.Data.Abstract;
using Layer.Entity.Concart;

namespace Layer.Business.Concart
{
    public class StudentScoreLogic : IStudentScoreLogic
    {
        private IStudent_Score_DAL dal;


        public StudentScoreLogic(IStudent_Score_DAL dal)
        {
            this.dal = dal;
        }


        public void Add(Student_Score score)
        {
            FValidationToStudent.InstenceValidation(new FluentValidationtoStudent(),score);
            dal.Add(score);              
        }

        public void Delete(Student_Score score)
        {
            try
            {
                dal.Delete(score);
            }

            catch
            {
                throw new Exception("Delete is not complete");
            }
            
        }

        public List<Student_Score> GetAll()
        {
            return dal.GetAll();
        }

        public List<Student_Score> GetByStudentID(int ID)
        {
            return dal.GetAll(p => p.StudentID == ID);
        }

        public void Update(Student_Score score)
        {
            FValidationToStudent.InstenceValidation(new FluentValidationtoStudent(),score);
            dal.Update(score);
        }
    }
}
