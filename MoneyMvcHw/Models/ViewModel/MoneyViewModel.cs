using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using MoneyMvcHw.Models;
using System.ComponentModel.DataAnnotations;

namespace MoneyMvcHw.Models.ViewModel
{
    public class MoneyViewModel
    {
        [Required(ErrorMessage = "請選擇類別")]
        [DisplayName("類別")]
        public MoneyCategory Category { get; set; }

        [Required(ErrorMessage = "請填入金額")]        
        [DisplayName("金額")]
        [Range(0, int.MaxValue, ErrorMessage = "超出範圍")]
        public int Total { get; set; }

        [VaiLessThanToday(ErrorMessage = "")]
        [Required(ErrorMessage = "請填入日期")]
        [DisplayName("日期")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "請填入備註")]
        [DisplayName("備註")]
        public string Description { get; set; }

    }
}