namespace DOL.WHD.Section14c.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployerMailingAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployerInfoes", "HasMailingAddress", c => c.Boolean());
            AddColumn("dbo.EmployerInfoes", "MailingAddress_Id", c => c.Guid());
            CreateIndex("dbo.EmployerInfoes", "MailingAddress_Id");
            AddForeignKey("dbo.EmployerInfoes", "MailingAddress_Id", "dbo.Addresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployerInfoes", "MailingAddress_Id", "dbo.Addresses");
            DropIndex("dbo.EmployerInfoes", new[] { "MailingAddress_Id" });
            DropColumn("dbo.EmployerInfoes", "MailingAddress_Id");
            DropColumn("dbo.EmployerInfoes", "HasMailingAddress");
        }
    }
}
