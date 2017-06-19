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

    public class WidgetItem
    {
        [Key]
        public int ItemId { get; set; }
        public int GsH { get; set; }
        public int GsW { get; set; }
        public int GsX { get; set; }
        public int GsY { get; set; }

        public virtual Widget Widget { get; set; }
    }
}