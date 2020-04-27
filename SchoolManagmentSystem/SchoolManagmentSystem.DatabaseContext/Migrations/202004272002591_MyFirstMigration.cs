namespace SchoolManagmentSystem.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyFirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassName = c.String(),
                        ClassShortName = c.String(),
                        EntryBy = c.String(),
                        EntryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        division_id = c.Int(nullable: false),
                        name = c.String(),
                        bn_name = c.String(),
                        lat = c.String(),
                        lon = c.String(),
                        url = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Divisions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        bn_name = c.String(),
                        url = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                        EntryBy = c.String(),
                        EntryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        UserType = c.String(),
                        IsActive = c.Int(nullable: false),
                        EntryBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionCode = c.String(),
                        SectionName = c.String(),
                        EntryBy = c.String(),
                        EntryDate = c.DateTime(nullable: false),
                        ShiftId = c.Int(nullable: false),
                        ShiftName = c.String(),
                        ClassId = c.Int(nullable: false),
                        ClassName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShiftName = c.String(),
                        EntryBy = c.String(),
                        EntryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentDetailsInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.String(),
                        ShiftName = c.String(),
                        RollNo = c.String(),
                        ClassName = c.String(),
                        GroupName = c.String(),
                        SectionName = c.String(),
                        Session = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DetailsInfoId = c.Int(nullable: false),
                        NameEnglish = c.String(),
                        NameBengali = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Nationality = c.String(),
                        Gender = c.String(),
                        Religion = c.String(),
                        PresentAddress = c.String(),
                        PresentPO = c.String(),
                        PresentPS = c.String(),
                        PresentDistrict = c.String(),
                        PresentPhone = c.String(),
                        PermanentAddress = c.String(),
                        PermanentPO = c.String(),
                        PermanentPS = c.String(),
                        PermanentDistrict = c.String(),
                        PermanentPhone = c.String(),
                        GuardianName = c.String(),
                        GuardianAddress = c.String(),
                        Active = c.String(),
                        UpdateBy = c.String(),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StudentDetailsInfoes", t => t.DetailsInfoId, cascadeDelete: true)
                .Index(t => t.DetailsInfoId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectCode = c.String(),
                        SubjectName = c.String(),
                        SubjectType = c.String(),
                        EntryBy = c.String(),
                        EntryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Upazilas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        district_id = c.Int(nullable: false),
                        name = c.String(),
                        bn_name = c.String(),
                        url = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentInfoes", "DetailsInfoId", "dbo.StudentDetailsInfoes");
            DropIndex("dbo.StudentInfoes", new[] { "DetailsInfoId" });
            DropTable("dbo.Upazilas");
            DropTable("dbo.Subjects");
            DropTable("dbo.StudentInfoes");
            DropTable("dbo.StudentDetailsInfoes");
            DropTable("dbo.Shifts");
            DropTable("dbo.Sections");
            DropTable("dbo.Logins");
            DropTable("dbo.Groups");
            DropTable("dbo.Divisions");
            DropTable("dbo.Districts");
            DropTable("dbo.Classes");
        }
    }
}
