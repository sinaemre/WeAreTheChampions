namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teamName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Match", "HomeTeamName", c => c.String());
            AddColumn("dbo.Match", "GuestTeamName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Match", "GuestTeamName");
            DropColumn("dbo.Match", "HomeTeamName");
        }
    }
}
