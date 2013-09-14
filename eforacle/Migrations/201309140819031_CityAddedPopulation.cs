namespace EFOracle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CityAddedPopulation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("DEMO.CITIES", "POPULATION", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("DEMO.CITIES", "Population", c => c.Long(nullable: false));
        }
    }
}
