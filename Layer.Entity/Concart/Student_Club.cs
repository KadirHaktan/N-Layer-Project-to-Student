using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.Entity.Abstract;

namespace Layer.Entity.Concart
{
    public class Student_Club:IEntity
    {  
        [Key]
        public int ClubID { get; set; }
        public string ClubName { get; set; }
    }
}
