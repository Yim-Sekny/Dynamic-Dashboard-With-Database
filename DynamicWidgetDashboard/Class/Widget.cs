using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicWidgetDashboard
{
    public class Widget
    {
        [Key, Required]
        public int WidgetId { get; set; }

        public string WidgetTitle { get; set; }

        //public virtual WidgetItem widgetItem { get; set; }
    }
}