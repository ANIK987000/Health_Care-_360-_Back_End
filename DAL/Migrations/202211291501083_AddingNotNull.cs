namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNotNull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Doctors", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Doctors", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Doctors", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Doctors", "Phone", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Doctors", "Address", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Doctors", "Qualification", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Hospitals", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Hospitals", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Hospitals", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Hospitals", "Location", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Patients", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Patients", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Patients", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Patients", "Phone", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Patients", "Address", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Patients", "Dob", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Patients", "BloodGroup", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Staffs", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Staffs", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Staffs", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Staffs", "Phone", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Staffs", "Address", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Staffs", "Address", c => c.String());
            AlterColumn("dbo.Staffs", "Phone", c => c.String());
            AlterColumn("dbo.Staffs", "Password", c => c.String());
            AlterColumn("dbo.Staffs", "Email", c => c.String());
            AlterColumn("dbo.Staffs", "Name", c => c.String());
            AlterColumn("dbo.Patients", "BloodGroup", c => c.String());
            AlterColumn("dbo.Patients", "Dob", c => c.String());
            AlterColumn("dbo.Patients", "Address", c => c.String());
            AlterColumn("dbo.Patients", "Phone", c => c.String());
            AlterColumn("dbo.Patients", "Password", c => c.String());
            AlterColumn("dbo.Patients", "Email", c => c.String());
            AlterColumn("dbo.Patients", "Name", c => c.String());
            AlterColumn("dbo.Hospitals", "Location", c => c.String());
            AlterColumn("dbo.Hospitals", "Password", c => c.String());
            AlterColumn("dbo.Hospitals", "Email", c => c.String());
            AlterColumn("dbo.Hospitals", "Name", c => c.String());
            AlterColumn("dbo.Doctors", "Qualification", c => c.String());
            AlterColumn("dbo.Doctors", "Address", c => c.String());
            AlterColumn("dbo.Doctors", "Phone", c => c.String());
            AlterColumn("dbo.Doctors", "Password", c => c.String());
            AlterColumn("dbo.Doctors", "Email", c => c.String());
            AlterColumn("dbo.Doctors", "Name", c => c.String());
        }
    }
}
