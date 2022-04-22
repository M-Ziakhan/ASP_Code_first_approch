namespace codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondatble : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sales",
                c => new
                    {
                        sale_id = c.Int(nullable: false, identity: true),
                        sale_product = c.String(),
                        sale_qty = c.String(),
                    })
                .PrimaryKey(t => t.sale_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.sales");
        }
    }
}
