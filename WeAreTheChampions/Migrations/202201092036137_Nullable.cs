namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Match", "HomeScore", c => c.Int());
            AlterColumn("dbo.Match", "AwayScore", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Match", "AwayScore", c => c.Int(nullable: false));
            AlterColumn("dbo.Match", "HomeScore", c => c.Int(nullable: false));
        }
    }
}
