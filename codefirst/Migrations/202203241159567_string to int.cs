namespace codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringtoint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.sales", "sale_qty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.sales", "sale_qty", c => c.String());
        }
    }
}
