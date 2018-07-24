using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoneyMvcHw.Models;

namespace MoneyMvcHw.Helper
{
    public static class CategoryColorHelper
    {
        public static HtmlString DisplayCategoryColor(this HtmlHelper htmlHelper, MoneyCategory moneyCategory)
        {
            string className = "";
            if (moneyCategory == MoneyCategory.支出)
            {
                className = "danger";
            }
            else if (moneyCategory == MoneyCategory.收入)
            {
                className = "success";
            }

            return new MvcHtmlString($"class={className}");
        }
    }
}