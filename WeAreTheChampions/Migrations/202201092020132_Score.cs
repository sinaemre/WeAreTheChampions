namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Score : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Match", "MatchScore", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Match", "MatchScore");
        }
    }
}
