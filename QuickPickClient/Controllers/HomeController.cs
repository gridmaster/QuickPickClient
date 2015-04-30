using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickPickClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Get your quick picks here!";

            ViewBag.MaxNumbers = GetNumbers(1, 75, 49);

            ViewBag.Picks = GetNumbers(1, 10, 6);

            ViewBag.MaxPB = GetNumbers(0, 49, 0);

            ViewBag.Tickets = GetNumbers(1, 50, 10);

            return View();
        }

        private List<SelectListItem> GetNumbers(int start, int count, int select) {
            List<SelectListItem> obj = new List<SelectListItem>();

            count++;

            for (int i = start; i < count; i++)
            {
                if (i == select)
                {
                    obj.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString(), Selected=true });
                }
                else
                {
                    obj.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
                }
            }
            return obj;
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "About the Quicker Picker.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us.";

            return View();
        }
    }
}
