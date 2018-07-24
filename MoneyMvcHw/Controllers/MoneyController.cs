using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoneyMvcHw.Models;
using MoneyMvcHw.Models.ViewModel;
using MoneyMvcHw.Service;

namespace MoneyMvcHw.Controllers
{
    public class MoneyController : Controller
    {
        private readonly MoneyService moneyService;

        public MoneyController()
        {
            moneyService = new MoneyService();
        }
        // GET: Money
        [Route("Money")]
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult ReportMoney()
        {
            var viewModel = MoneyData.GetFakeData().ToList();            
            return View(viewModel);
        }

        public ActionResult Creat()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Creat(MoneyViewModel moneyViewModel)
        {
            //Q1 驗證沒過之後 傳回
            if (ModelState.IsValid)
            {
                moneyService.Add(moneyViewModel);
                moneyService.Save();
                return RedirectToAction("Index");
            }            
            return View("Index",moneyViewModel);
        }
    }
}