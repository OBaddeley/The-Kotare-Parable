namespace KotareParable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Narrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Statement = c.String(),
                        Yes = c.Int(nullable: false),
                        No = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Narrations");
        }
    }
}
