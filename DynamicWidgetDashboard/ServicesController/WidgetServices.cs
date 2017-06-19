using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicWidgetDashboard.ServicesController
{
    public class WidgetServices
    {
        private DynamicWidgetCon context = new DynamicWidgetCon();

        public List<Widget> GetWidgets()
        {
            return context.Widget.ToList();
        }

        public Widget GetWidget(int id)
        {
            throw new NotImplementedException();
        }
    }
}