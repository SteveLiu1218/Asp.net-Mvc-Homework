using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoneyMvcHw.Models
{
    //若方法或屬性宣告為密封(sealed)，則不可以被子類別覆寫
    public sealed class VaiLessThanToday:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            if (DateTime.TryParse(value.ToString(),out DateTime inputDateTime))
            {
                if (inputDateTime <= DateTime.Now)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("日期不可以大於今天");
        }
    }
}
