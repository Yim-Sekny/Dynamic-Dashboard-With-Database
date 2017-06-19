using DynamicWidgetDashboard.ServicesController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicWidgetDashboard.Controllers
{
    public class BaseController
    {
        protected DynamicWidgetCon context = new DynamicWidgetCon();
        protected WidgetServices widgetService = new WidgetServices();
    }
}