using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoneyMvcHw.Models;
using MoneyMvcHw.Models.ViewModel;

namespace MoneyMvcHw.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
        [Route("Money")]
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult ReportMoney()
        {
            var fakeMoneyData = GetFakeMoneyData(50);
            return View(fakeMoneyData);
        }
        public List<MoneyViewModel> GetFakeMoneyData(int FakeDataCount)
        {
            var moneyReport = new List<MoneyViewModel>();
            for (int i = 0; i < FakeDataCount; i++)
            {
                var fakeData = new MoneyViewModel();
                {
                    if (i % 2 == 0)
                    {
                        fakeData.Category = MoneyCategory.收入;
                        
                    }
                    else
                    {
                        fakeData.Category = MoneyCategory.支出;
                    }
                    fakeData.Total = i * 100;
                    fakeData.Date = DateTime.Today;
                }
                moneyReport.Add(fakeData);
            }
            return moneyReport;
        }
    }
}