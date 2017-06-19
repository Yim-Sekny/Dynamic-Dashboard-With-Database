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
}