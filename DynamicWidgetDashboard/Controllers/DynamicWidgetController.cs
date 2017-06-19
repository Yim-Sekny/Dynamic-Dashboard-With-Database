using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DynamicWidgetDashboard.Controllers
{
    public class DynamicWidgetController : ApiController
    {
        private DynamicWidgetCRUD db = new DynamicWidgetCRUD();

        #region Widget
        // GET: api/DynamicWidget
        [HttpGet]
        [ActionName("GetWidgets")]
        public IEnumerable<Widget> GetStoreWidgets()
        {
            return db.GetWidgets();
        }

        [HttpGet]
        [ActionName("GetWidget")]
        public IHttpActionResult GetStoreWidget(int id)
        {
            var widget = db.GetWidget(id);
            if (widget == null)
            {
                return NotFound();//404 Not Found
            }
            return Ok(widget);
        }
        
        // POST: api/DynamicWidget
        [HttpPost]
        public IHttpActionResult Post(Widget widget)
        {
            if (db.SaveWidget(widget))
            {
                return Ok();
            }
            return BadRequest();
        }

        // PUT: api/DynamicWidget/5
        [HttpPut]
        public IHttpActionResult Put(Widget widget)
        {
            if (db.UpdateWidget(widget))
            {
                return Ok();
            }
            return BadRequest();
        }

        // DELETE: api/DynamicWidget/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (db.DeleteWidget(id)) return Ok();
            return BadRequest();
        }
        #endregion Widget

        #region Widget Item
        // GET: api/DynamicWidget
        [HttpGet]
        [ActionName("GetWidgetItems")]
        public IEnumerable<WidgetItem> GetStoreWidgetItems()
        {
            return db.GetWidgetItems();
        }

        [HttpGet]
        [ActionName("GetWidgetItem")]
        public IHttpActionResult GetStoreWidgetItem(int id)
        {
            //var widgetItem = db.GetWidgetItem(id);
            //if (widgetItem == null)
            //{
            //    return NotFound();//404 Not Found
            //}
            //return Ok(widgetItem);
            return Ok();
        }

        // POST: api/DynamicWidget
        [HttpPost]
        public IHttpActionResult SaveWidgetItem(WidgetItem WidgetItem)
        {
            if (db.SaveWidgetItems(WidgetItem))
            {
                return Ok();
            }
            return BadRequest();
        }

        // PUT: api/DynamicWidget/5
        [HttpPost]
        public IHttpActionResult UpdateWidgetItem(WidgetItem[] WidgetItems)
        {
            if (db.UpdateWidgetItem(WidgetItems))
            {
                return Ok();
            }
            return BadRequest();
        }

        // DELETE: api/DynamicWidget/5
        [HttpDelete]
        public IHttpActionResult DeleteWidgetItem(int id)
        {
            if (db.DeleteWidget(id)) return Ok();
            return BadRequest();
        }
        #endregion Widget Item
    }

    public class DynamicWidgetCRUD : BaseController
    {
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
            } catch (Exception)
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
                var widgetItem = context.WidgetItem.Where(w => w.ItemId== ItemId).FirstOrDefault();
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
