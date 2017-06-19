using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DynamicWidgetDashboard.Controllers
{
    public class DynamicWidgetController : ApiController
    {
        private BaseController bases = new BaseController();

        #region Widget
        // GET: api/DynamicWidget
        [HttpGet]
        [ActionName("GetWidgets")]
        public IEnumerable<Widget> GetStoreWidgets()
        {
            return bases.GetWidgets();
        }

        [HttpGet]
        [ActionName("GetWidget")]
        public IHttpActionResult GetStoreWidget(int id)
        {
            var widget = bases.GetWidget(id);
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
            if (bases.SaveWidget(widget))
            {
                return Ok();
            }
            return BadRequest();
        }

        // PUT: api/DynamicWidget/5
        [HttpPut]
        public IHttpActionResult Put(Widget widget)
        {
            if (bases.UpdateWidget(widget))
            {
                return Ok();
            }
            return BadRequest();
        }

        // DELETE: api/DynamicWidget/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            if (bases.DeleteWidget(id)) return Ok();
            return BadRequest();
        }
        #endregion Widget

        #region Widget Item
        // GET: api/DynamicWidget
        [HttpGet]
        [ActionName("GetWidgetItems")]
        public IEnumerable<WidgetItem> GetStoreWidgetItems()
        {
            return bases.GetWidgetItems();
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
            if (bases.SaveWidgetItems(WidgetItem))
            {
                return Ok();
            }
            return BadRequest();
        }

        // PUT: api/DynamicWidget/5
        [HttpPost]
        public IHttpActionResult UpdateWidgetItem(WidgetItem[] WidgetItems)
        {
            if (bases.UpdateWidgetItem(WidgetItems))
            {
                return Ok();
            }
            return BadRequest();
        }

        // DELETE: api/DynamicWidget/5
        [HttpDelete]
        public IHttpActionResult DeleteWidgetItem(int id)
        {
            if (bases.DeleteWidget(id)) return Ok();
            return BadRequest();
        }
        #endregion Widget Item
    }
}
