namespace Km5Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Artist = c.Int(nullable: false),
                        Url = c.String(),
                        Image = c.String(),
                        Listeners = c.String(),
                        Playcount = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        url = c.String(),
                        image = c.String(),
                        bio = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Year = c.String(),
                        Rated = c.String(),
                        Released = c.String(),
                        Runtime = c.String(),
                        Genre = c.String(),
                        Director = c.String(),
                        Writer = c.String(),
                        Actors = c.String(),
                        Plot = c.String(),
                        Language = c.String(),
                        Country = c.String(),
                        Awards = c.String(),
                        Poster = c.String(),
                        imdbRating = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
            DropTable("dbo.Artists");
            DropTable("dbo.Albums");
        }
    }
}
