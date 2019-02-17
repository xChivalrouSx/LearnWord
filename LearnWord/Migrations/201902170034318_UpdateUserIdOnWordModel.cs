namespace LearnWord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserIdOnWordModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WordModels", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.WordModels", new[] { "User_Id" });
            AddColumn("dbo.WordModels", "UserId", c => c.String(nullable: false));
            DropColumn("dbo.WordModels", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WordModels", "User_Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.WordModels", "UserId");
            CreateIndex("dbo.WordModels", "User_Id");
            AddForeignKey("dbo.WordModels", "User_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
