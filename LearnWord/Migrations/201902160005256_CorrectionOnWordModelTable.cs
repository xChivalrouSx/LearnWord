namespace LearnWord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectionOnWordModelTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WordModels", "SentencesNumber");
            DropColumn("dbo.WordModels", "SynonymsNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WordModels", "SynonymsNumber", c => c.Int(nullable: false));
            AddColumn("dbo.WordModels", "SentencesNumber", c => c.Int(nullable: false));
        }
    }
}
