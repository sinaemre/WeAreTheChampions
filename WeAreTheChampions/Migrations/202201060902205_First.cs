namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ColorPaint",
                c => new
                    {
                        ColorPaintId = c.Int(nullable: false, identity: true),
                        ColorName = c.String(nullable: false, maxLength: 100),
                        Red = c.Double(nullable: false),
                        Green = c.Double(nullable: false),
                        Blue = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ColorPaintId);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false, maxLength: 200),
                        Logo = c.String(),
                        MascotName = c.String(),
                        MascotPicture = c.String(),
                        TeamRating = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.Match",
                c => new
                    {
                        MatchId = c.Int(nullable: false, identity: true),
                        HomeScore = c.Int(nullable: false),
                        AwayScore = c.Int(nullable: false),
                        MatchTime = c.DateTime(nullable: false),
                        Result = c.Int(nullable: false),
                        HomeTeamId = c.Int(nullable: false),
                        GuestTeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MatchId)
                .ForeignKey("dbo.Team", t => t.GuestTeamId)
                .ForeignKey("dbo.Team", t => t.HomeTeamId)
                .Index(t => t.HomeTeamId)
                .Index(t => t.GuestTeamId);
            
            CreateTable(
                "dbo.Player",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        BirthPlace = c.String(),
                        BirthDate = c.DateTime(),
                        PlayerPhoto = c.String(),
                        Pace = c.Int(nullable: false),
                        Shoot = c.Int(nullable: false),
                        Pass = c.Int(nullable: false),
                        Drippling = c.Int(nullable: false),
                        Physics = c.Int(nullable: false),
                        Defence = c.Int(nullable: false),
                        Position = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.Team", t => t.TeamId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.TeamColorPaints",
                c => new
                    {
                        Team_TeamId = c.Int(nullable: false),
                        ColorPaint_ColorPaintId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Team_TeamId, t.ColorPaint_ColorPaintId })
                .ForeignKey("dbo.Team", t => t.Team_TeamId, cascadeDelete: true)
                .ForeignKey("dbo.ColorPaint", t => t.ColorPaint_ColorPaintId, cascadeDelete: true)
                .Index(t => t.Team_TeamId)
                .Index(t => t.ColorPaint_ColorPaintId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Player", "TeamId", "dbo.Team");
            DropForeignKey("dbo.TeamColorPaints", "ColorPaint_ColorPaintId", "dbo.ColorPaint");
            DropForeignKey("dbo.TeamColorPaints", "Team_TeamId", "dbo.Team");
            DropForeignKey("dbo.Match", "HomeTeamId", "dbo.Team");
            DropForeignKey("dbo.Match", "GuestTeamId", "dbo.Team");
            DropIndex("dbo.TeamColorPaints", new[] { "ColorPaint_ColorPaintId" });
            DropIndex("dbo.TeamColorPaints", new[] { "Team_TeamId" });
            DropIndex("dbo.Player", new[] { "TeamId" });
            DropIndex("dbo.Match", new[] { "GuestTeamId" });
            DropIndex("dbo.Match", new[] { "HomeTeamId" });
            DropTable("dbo.TeamColorPaints");
            DropTable("dbo.Player");
            DropTable("dbo.Match");
            DropTable("dbo.Team");
            DropTable("dbo.ColorPaint");
        }
    }
}
