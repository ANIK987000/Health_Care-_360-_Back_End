namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePatientChekupList1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PatientCheckUps", "PatientID", "dbo.Patients");
            DropIndex("dbo.PatientCheckUps", new[] { "PatientID" });
            AddColumn("dbo.PatientCheckUps", "Medicine", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.PatientCheckUps", "MedicineName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PatientCheckUps", "MedicineName", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.PatientCheckUps", "Medicine");
            CreateIndex("dbo.PatientCheckUps", "PatientID");
            AddForeignKey("dbo.PatientCheckUps", "PatientID", "dbo.Patients", "ID", cascadeDelete: true);
        }
    }
}
