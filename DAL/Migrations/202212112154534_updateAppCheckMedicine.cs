namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateAppCheckMedicine : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PatientCheckUps", "DoctorID", "dbo.Doctors");
            DropForeignKey("dbo.Medicines", "Medicine_Id", "dbo.Medicines");
            DropForeignKey("dbo.Prescriptions", "Medicines_Id", "dbo.Medicines");
            DropIndex("dbo.PatientCheckUps", new[] { "DoctorID" });
            DropIndex("dbo.Medicines", new[] { "Medicine_Id" });
            DropIndex("dbo.Prescriptions", new[] { "Medicines_Id" });
            AddColumn("dbo.Appointments", "PatientName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Appointments", "DoctorName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.PatientCheckUps", "PatientName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.PatientCheckUps", "DoctorName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.PatientCheckUps", "MedicineName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Medicines", "MedicineName", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.PatientCheckUps", "Medicine");
            DropColumn("dbo.Medicines", "Name");
            DropColumn("dbo.Medicines", "Medicine_Id");
            DropTable("dbo.Prescriptions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedicineID = c.String(nullable: false, maxLength: 100),
                        No_Of_Days = c.Int(nullable: false),
                        Taking_Time = c.String(nullable: false, maxLength: 100),
                        BeforeMeal = c.String(nullable: false, maxLength: 100),
                        Medicines_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Medicines", "Medicine_Id", c => c.Int());
            AddColumn("dbo.Medicines", "Name", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.PatientCheckUps", "Medicine", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Medicines", "MedicineName");
            DropColumn("dbo.PatientCheckUps", "MedicineName");
            DropColumn("dbo.PatientCheckUps", "DoctorName");
            DropColumn("dbo.PatientCheckUps", "PatientName");
            DropColumn("dbo.Appointments", "DoctorName");
            DropColumn("dbo.Appointments", "PatientName");
            CreateIndex("dbo.Prescriptions", "Medicines_Id");
            CreateIndex("dbo.Medicines", "Medicine_Id");
            CreateIndex("dbo.PatientCheckUps", "DoctorID");
            AddForeignKey("dbo.Prescriptions", "Medicines_Id", "dbo.Medicines", "Id");
            AddForeignKey("dbo.Medicines", "Medicine_Id", "dbo.Medicines", "Id");
            AddForeignKey("dbo.PatientCheckUps", "DoctorID", "dbo.Doctors", "ID", cascadeDelete: true);
        }
    }
}
