using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Layer.Entity.Concart;

namespace Layer.Business.Validation.FlueValidation
{
   public class FluentValidationtoStudent:AbstractValidator<Student>
    {
        public FluentValidationtoStudent()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("İsim boş bırakılamaz");
            RuleFor(p => p.Surname).NotEmpty().WithMessage("Soyad boş bırakılamaz");

            RuleFor(p => p.ClubID).NotEmpty().WithMessage("Kulüp ID'sı boş bırakılamaz");


        }
        
    }
}
