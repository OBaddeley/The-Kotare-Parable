namespace KotareParable.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_responses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NtoRs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NarrationId = c.Int(nullable: false),
                        ResponseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Narrations", t => t.NarrationId, cascadeDelete: true)
                .ForeignKey("dbo.Responses", t => t.ResponseId, cascadeDelete: true)
                .Index(t => t.NarrationId)
                .Index(t => t.ResponseId);
            
            CreateTable(
                "dbo.Responses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Statement = c.String(),
                        NarrationId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Narrations", t => t.NarrationId)
                .Index(t => t.NarrationId);
            
            DropColumn("dbo.Narrations", "Yes");
            DropColumn("dbo.Narrations", "No");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Narrations", "No", c => c.Int(nullable: false));
            AddColumn("dbo.Narrations", "Yes", c => c.Int(nullable: false));
            DropForeignKey("dbo.NtoRs", "ResponseId", "dbo.Responses");
            DropForeignKey("dbo.NtoRs", "NarrationId", "dbo.Narrations");
            DropForeignKey("dbo.Responses", "NarrationId", "dbo.Narrations");
            DropIndex("dbo.Responses", new[] { "NarrationId" });
            DropIndex("dbo.NtoRs", new[] { "ResponseId" });
            DropIndex("dbo.NtoRs", new[] { "NarrationId" });
            DropTable("dbo.Responses");
            DropTable("dbo.NtoRs");
        }
    }
}
