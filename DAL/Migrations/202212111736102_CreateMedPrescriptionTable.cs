namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMedPrescriptionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Medicine_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicines", t => t.Medicine_Id)
                .Index(t => t.Medicine_Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicines", t => t.Medicines_Id)
                .Index(t => t.Medicines_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prescriptions", "Medicines_Id", "dbo.Medicines");
            DropForeignKey("dbo.Medicines", "Medicine_Id", "dbo.Medicines");
            DropIndex("dbo.Prescriptions", new[] { "Medicines_Id" });
            DropIndex("dbo.Medicines", new[] { "Medicine_Id" });
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Medicines");
        }
    }
}
