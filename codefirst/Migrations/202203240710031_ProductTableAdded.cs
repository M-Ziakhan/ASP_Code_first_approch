namespace codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        productid = c.Int(nullable: false, identity: true),
                        productName = c.String(),
                        price = c.Int(nullable: false),
                        qty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.productid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
