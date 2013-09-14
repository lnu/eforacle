namespace EFOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "DEMO.REGIONS",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NAME = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "DEMO.COUNTRIES",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NAME = c.String(nullable: false),
                        REGION_ID = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("DEMO.REGIONS", t => t.REGION_ID, cascadeDelete: true)
                .Index(t => t.REGION_ID);
            
        }
        
        public override void Down()
        {
            DropIndex("DEMO.COUNTRIES", new[] { "REGION_ID" });
            DropForeignKey("DEMO.COUNTRIES", "REGION_ID", "DEMO.REGIONS");
            DropTable("DEMO.COUNTRIES");
            DropTable("DEMO.REGIONS");
        }
    }
}
