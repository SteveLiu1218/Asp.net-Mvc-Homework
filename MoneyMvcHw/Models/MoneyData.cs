using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoneyMvcHw.Models.ViewModel;
using MoneyMvcHw.Service;

namespace MoneyMvcHw.Models
{
    public class MoneyData
    {
        public static IEnumerable<MoneyViewModel> GetFakeData()
        {
            var moneyService = new MoneyService();
            var query = from d in moneyService.GetAll()
                        select new MoneyViewModel
                        {
                            Category    = (MoneyCategory)d.Categoryyy,
                            Total       = d.Amounttt,
                            Date        = d.Dateee,
                            Description = d.Remarkkk
                        };
            return query;
        }
    }
}