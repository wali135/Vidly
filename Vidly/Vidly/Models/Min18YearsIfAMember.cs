using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;
            if (customer.MembershipTypeId ==MembershipType.Unknown ||customer.MembershipTypeId==MembershipType.PayAsYouGo ||  customer.MembershipTypeId == 1)
                return ValidationResult.Success;

            if (customer.BirthdayDate == null) 
                return new ValidationResult("Birthday is Required");

            var age = DateTime.Today.Year - customer.BirthdayDate.Value.Year;

            return (age > 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer Should be at least 18 to go on membership");
        }
    }
}