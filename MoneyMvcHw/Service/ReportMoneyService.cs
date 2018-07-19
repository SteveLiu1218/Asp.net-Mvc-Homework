using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyMvcHw.Service
{
    public class ReportMoneyService
    {
        private readonly ReportMoneyEntity reportMoneyEntity;
        public ReportMoneyService()
        {
            reportMoneyEntity = new ReportMoneyEntity();
        }
        public IEnumerable<AccountBook> GetAll()
        {
            return reportMoneyEntity.AccountBook.ToList();
        }
    }
}