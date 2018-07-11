using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using MoneyMvcHw.Models;

namespace MoneyMvcHw.Models.ViewModel
{
    public class MoneyViewModel
    {
        [DisplayName("類別")]
        public MoneyCategory Category { get; set; }

        [DisplayName("金額")]
        public int Total { get; set; }

        [DisplayName("日期")]
        public string Date { get; set; }

        [DisplayName("備註")]
        public string Description { get; set; }

    }
}