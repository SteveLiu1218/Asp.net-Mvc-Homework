using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoneyMvcHw.Models;
using MoneyMvcHw.Models.ViewModel;

namespace MoneyMvcHw.Service
{
    public class MoneyService
    {
        private readonly ReportMoneyEntity _db;
        public MoneyService()
        {
            _db = new ReportMoneyEntity();
        }
        public IEnumerable<AccountBook> GetAll()
        {
            return _db.AccountBook.ToList();
        }
        public void Add(MoneyViewModel moneyViewModel)
        {            
            _db.AccountBook.Add(new AccountBook()
            {
                Id         = Guid.NewGuid(),
                Amounttt   = moneyViewModel.Total,
                Dateee     = moneyViewModel.Date,
                Remarkkk   = moneyViewModel.Description,
                Categoryyy = Convert.ToInt32(moneyViewModel.Category)
            });
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}