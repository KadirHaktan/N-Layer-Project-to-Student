using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer.Entity.Abstract;

namespace Layer.Entity.Concart
{
   public class Student:IEntity
    {
         [Key]
         public int ID { get; set; }
         public string Name { get; set; }
         public string Surname { get; set; }
         public int ClubID { get; set; }

    }
}
