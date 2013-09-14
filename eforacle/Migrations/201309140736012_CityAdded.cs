namespace EFOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CityAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "DEMO.CITIES",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NAME = c.String(nullable: false),
                        Population = c.Long(nullable: false),
                        COUNTDY_IF = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("DEMO.COUNTRIES", t => t.COUNTDY_IF, cascadeDelete: true)
                .Index(t => t.COUNTDY_IF);
            
        }
        
        public override void Down()
        {
            DropIndex("DEMO.CITIES", new[] { "COUNTDY_IF" });
            DropForeignKey("DEMO.CITIES", "COUNTDY_IF", "DEMO.COUNTRIES");
            DropTable("DEMO.CITIES");
        }
    }
}
