namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TokenTypeAdd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tokens", "Type", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tokens", "Type", c => c.String());
        }
    }
}
