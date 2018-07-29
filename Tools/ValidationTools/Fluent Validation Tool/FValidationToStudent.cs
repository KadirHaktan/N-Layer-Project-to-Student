using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Resources;

namespace Layer.Business.Tools.ValidationTools.Fluent_Validation_Tool
{
    class FValidationToStudent
    {
        public static void InstenceValidation(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);


            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
