using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicWidgetDashboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public void InsertWidget()
        {
            var context = new DynamicWidgetCon();
            var widget = new Widget
            {
                WidgetId = 1,
                WidgetTitle = "Bar Chart"
            };
            context.Widget.Add(widget);
            context.SaveChanges();
        }
    }
}