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
        public List<MoneyViewModel> GetFakeMoneyData(int iCount)
        {
            var moneyReport = new List<MoneyViewModel>();
            for (int intA = 0; intA < iCount; intA++)
            {
                var fakeData = new MoneyViewModel();
                {
                    if (intA % 2 == 0)
                    {
                        fakeData.Category = new MoneyCategory()
                        {
                            Id = 1,
                            Category = "支出"
                        };
                    }
                    else
                    {
                        fakeData.Category = new MoneyCategory()
                        {
                            Id = 2,
                            Category = "收入"
                        };
                    }
                    fakeData.Total = intA * 100;
                    fakeData.Date = DateTime.Today;
                }
                moneyReport.Add(fakeData);
            }
            return moneyReport;
        }
    }
}