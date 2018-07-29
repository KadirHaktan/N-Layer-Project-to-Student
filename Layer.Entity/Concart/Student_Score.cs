using Layer.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Entity.Concart
{
   public class Student_Score:IEntity
    {
        [Key]
        public int StudentID { get; set; }
        public int FirstExam { get; set; }
        public int SecondExam { get; set; }
        public int Project { get; set; }

    }
}
