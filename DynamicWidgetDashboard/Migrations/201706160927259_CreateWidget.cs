namespace DynamicWidgetDashboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateWidget : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Widgets",
                c => new
                    {
                        widgetId = c.Int(nullable: false, identity: true),
                        widgetTitle = c.String(),
                    })
                .PrimaryKey(t => t.widgetId);
            
            CreateTable(
                "dbo.WidgetItems",
                c => new
                    {
                        itemId = c.Int(nullable: false, identity: true),
                        gsH = c.Int(nullable: false),
                        gsW = c.Int(nullable: false),
                        gsX = c.Int(nullable: false),
                        gsY = c.Int(nullable: false),
                        widget_widgetId = c.Int(),
                    })
                .PrimaryKey(t => t.itemId)
                .ForeignKey("dbo.Widgets", t => t.widget_widgetId)
                .Index(t => t.widget_widgetId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WidgetItems", "widget_widgetId", "dbo.Widgets");
            DropIndex("dbo.WidgetItems", new[] { "widget_widgetId" });
            DropTable("dbo.WidgetItems");
            DropTable("dbo.Widgets");
        }
    }
}
