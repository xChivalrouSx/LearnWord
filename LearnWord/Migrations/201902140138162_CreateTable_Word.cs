namespace LearnWord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable_Word : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WordModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Word = c.String(nullable: false),
                        Category = c.String(),
                        Meaning = c.String(),
                        User_Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WordModels", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.WordModels", new[] { "User_Id" });
            DropTable("dbo.WordModels");
        }
    }
}
