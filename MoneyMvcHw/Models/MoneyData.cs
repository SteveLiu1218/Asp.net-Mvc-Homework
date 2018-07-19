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
        public IEnumerable<MoneyViewModel> GetFakeData()
        {
            ReportMoneyService reportMoneyService = new ReportMoneyService();
            var query = from d in reportMoneyService.GetAll()
                        select new MoneyViewModel
                        {
                            Category = (MoneyCategory)d.Categoryyy,
                            Total = d.Amounttt,
                            Date = d.Dateee,
                            Description = d.Remarkkk
                        };
            return query;
        }

    }
}