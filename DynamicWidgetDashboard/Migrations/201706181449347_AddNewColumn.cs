namespace DynamicWidgetDashboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewColumn : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.WidgetItems", new[] { "widget_widgetId" });
            CreateIndex("dbo.WidgetItems", "Widget_WidgetId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.WidgetItems", new[] { "Widget_WidgetId" });
            CreateIndex("dbo.WidgetItems", "widget_widgetId");
        }
    }
}
