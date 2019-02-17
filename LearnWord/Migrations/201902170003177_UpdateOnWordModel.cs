namespace LearnWord.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOnWordModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WordModels", "Sentences", c => c.String());
            AddColumn("dbo.WordModels", "Synonyms", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WordModels", "Synonyms");
            DropColumn("dbo.WordModels", "Sentences");
        }
    }
}
