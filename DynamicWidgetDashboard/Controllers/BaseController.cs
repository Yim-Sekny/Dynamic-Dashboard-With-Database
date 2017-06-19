using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DynamicWidgetDashboard.Controllers
{
    public class BaseController : Controller
    {
        protected DynamicWidgetCon context = new DynamicWidgetCon();

        #region Dummy Data
        public void InsertWidget()
        {
            if(GetWidgets().Count == 0)
            {
                Widget widget = new Widget();

                //widget.WidgetId = 1;
                widget.WidgetTitle = "Doughnut Chart";
                context.Widget.Add(widget);
                context.SaveChanges();

                //widget.WidgetId = 2;
                widget.WidgetTitle = "Pie Chart";
                context.Widget.Add(widget);
                context.SaveChanges();

                //widget.WidgetId = 3;
                widget.WidgetTitle = "Bar Chart";
                context.Widget.Add(widget);
                context.SaveChanges();

                InsertWidgetItem();
            }
        }

        public void InsertWidgetItem()
        {
            if (GetWidgetItems().Count == 0)
            {
                WidgetItem widgetItem = new WidgetItem();

                //widgetItem.Widget.WidgetId = 1;
                //widgetItem.Widget.WidgetTitle = "Doughnut Chart";
                //widgetItem.ItemId = 1;
                widgetItem.GsH = 4;
                widgetItem.GsW = 3;
                widgetItem.GsX = 0;
                widgetItem.GsY = 0;
                context.WidgetItem.Add(widgetItem);
                context.SaveChanges();

                //.Widget.WidgetId = 2;
                //widgetItem.Widget.WidgetTitle = "Pie Chart";
                //widgetItem.ItemId = 2;
                widgetItem.GsH = 9;
                widgetItem.GsW = 9;
                widgetItem.GsX = 3;
                widgetItem.GsY = 0;
                context.WidgetItem.Add(widgetItem);
                context.SaveChanges();

                //widgetItem.Widget.WidgetId = 3;
                //widgetItem.Widget.WidgetTitle = "Bar Chart";
                //widgetItem.ItemId = 3;
                widgetItem.GsH = 5;
                widgetItem.GsW = 3;
                widgetItem.GsX = 0;
                widgetItem.GsY = 4;
                context.WidgetItem.Add(widgetItem);
                context.SaveChanges();
            }
        }
        #endregion Dummy Data

        #region widget
        public List<Widget> GetWidgets()
        {
            return context.Widget.ToList();
        }

        public Widget GetWidget(int id)
        {
            return context.Widget.Where(w => w.WidgetId == id).FirstOrDefault();
        }
        public bool SaveWidget(Widget widget)
        {
            try
            {
                context.Widget.Add(widget);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SaveWidget(Widget[] widget)
        {
            try
            {
                if (widget.Length > 0)
                {
                    int i = 0;
                    while (i < widget.Length)
                    {
                        context.Widget.Add(widget[i]);
                    }
                    context.SaveChanges();
                    return true;
                }
                return false;
                
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateWidget(Widget widget)
        {
            try
            {
                context.Entry(widget).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteWidget(int widgetId)
        {
            try
            {
                var widget = context.Widget.Where(w => w.WidgetId == widgetId).FirstOrDefault();
                if (widget == null) return false;
                context.Entry(widget).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion widget

        #region widget Item
        public List<WidgetItem> GetWidgetItems()
        {
            return context.WidgetItem.ToList();
        }

        public bool SaveWidgetItems(WidgetItem widgetItem)
        {
            try
            {
                context.WidgetItem.Add(widgetItem);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateWidgetItem(WidgetItem[] widgetItem)
        {
            try
            {
                int i = 0;
                while (i < widgetItem.Length)
                {
                    context.Entry(widgetItem[i]).State = System.Data.Entity.EntityState.Modified;
                    i++;
                }
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateWidgetItem(WidgetItem widgetItem)
        {
            try
            {
                context.Entry(widgetItem).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteWidgetItem(int ItemId)
        {
            try
            {
                var widgetItem = context.WidgetItem.Where(w => w.ItemId == ItemId).FirstOrDefault();
                if (widgetItem == null) return false;
                context.Entry(widgetItem).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion widget Item
    }
}