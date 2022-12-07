using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class Min18IfMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1)
                return ValidationResult.Success;
            if (customer.BirthdayDate == null)
                return new ValidationResult("brithdate is required");
            var age = DateTime.Today.Year - customer.BirthdayDate.Value.Year;
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("the customer should be at least over 18 ");

        }
    }
}