namespace CodeMigrationTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgeMajor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "Major", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Major");
            DropColumn("dbo.Students", "Age");
        }
    }
}
