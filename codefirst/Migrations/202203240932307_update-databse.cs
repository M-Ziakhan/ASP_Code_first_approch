namespace codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "remarks", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "remarks");
        }
    }
}
