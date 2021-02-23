using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace D04.同步內容.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> About()
        {
            var result1 = $"[Threadid:{Thread.CurrentThread.ManagedThreadId} {System.Web.HttpContext.Current}]";
            await Task.Run(() => { Thread.Sleep(10); });
            var result2 = $"[Threadid:{Thread.CurrentThread.ManagedThreadId} {System.Web.HttpContext.Current}]";
            ViewBag.Message = $"Your application description page."
                + $"Result1:{result1}"
                + $"Result2:{result2}";

            return View();
        }

        public async Task<ActionResult> Contact()
        {
            var result1 = $"[Threadid:{Thread.CurrentThread.ManagedThreadId} {System.Web.HttpContext.Current}]";
            await Task.Run(() => { Thread.Sleep(10); }).ConfigureAwait(false);
            var result2 = $"[Threadid:{Thread.CurrentThread.ManagedThreadId} {System.Web.HttpContext.Current}]";
            ViewBag.Message = "Your contact page."
                + $"Result1:{result1}"
                + $"Result2:{result2}";

            return View();
        }
    }
}