using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamicWidgetDashboard
{
    public class DynamicWidgetCon: DbContext
    {
        public DbSet<Widget> Widget { get; set; }
        public DbSet<WidgetItem> WidgetItem { get; set; }   
    }

    public class DummyData
    {
        public void InsertWidgetData(Widget _widget) {
            var context = new DynamicWidgetCon();
            var widget = new Widget()
            {
                WidgetId = _widget.WidgetId,
                WidgetTitle = _widget.WidgetTitle
            };
            context.Widget.Add(widget);
            context.SaveChanges();
        }

        public void InsertWidgetItemData(WidgetItem _widgetItem)
        {
            var context = new DynamicWidgetCon();
            var widgetItem = new WidgetItem()
            {
                ItemId = _widgetItem.ItemId,
                GsH = _widgetItem.GsH,
                GsW = _widgetItem.GsW,
                GsX = _widgetItem.GsX,
                GsY = _widgetItem.GsY,
                Widget = _widgetItem.Widget
            };
            context.WidgetItem.Add(widgetItem);
            context.SaveChanges();
        }
    }
}