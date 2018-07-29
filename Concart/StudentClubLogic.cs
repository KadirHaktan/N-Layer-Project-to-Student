using Layer.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.Data.Abstract;
using Layer.Entity.Concart;

namespace Layer.Business.Concart
{
    public class StudentClubLogic : IStudentClubLogic
    {
        private IStudent_Club_DAL dal;

        public StudentClubLogic(IStudent_Club_DAL dal)
        {
            this.dal = dal;
        }


        public List<Student_Club> GetAll()
        {
            return dal.GetAll();
        }
    }
}
