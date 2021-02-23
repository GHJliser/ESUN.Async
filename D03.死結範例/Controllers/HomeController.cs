using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace D03.死結範例.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var r = CalculateAsync(3).Result;
            ViewBag.Message = $"Your application description page. Result:{r}";

            return View();
        }

        private async Task<int> CalculateAsync(int i)
        {
            await Task.Delay(2000);
            return i * i;
        }

        public async Task<ActionResult> Contact()
        {
            var r = await CalculateAsync(3);
            ViewBag.Message = $"Your contact page. Result:{r}";

            return View();
        }
    }
}