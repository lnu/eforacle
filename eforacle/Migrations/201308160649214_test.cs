namespace EFOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        id = c.Decimal(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        id = c.Decimal(nullable: false, identity: true),
                        Name = c.String(),
                        Region_id = c.Decimal(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Regions", t => t.Region_id)
                .Index(t => t.Region_id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Countries", new[] { "Region_id" });
            DropForeignKey("dbo.Countries", "Region_id", "dbo.Regions");
            DropTable("dbo.Countries");
            DropTable("dbo.Regions");
        }
    }
}
