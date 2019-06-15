namespace univ_hostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Specialities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 255),
                        Name = c.String(nullable: false),
                        Faculty_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faculties", t => t.Faculty_Id, cascadeDelete: true)
                .Index(t => t.Code, unique: true)
                .Index(t => t.Faculty_Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        EducationType = c.Int(nullable: false),
                        Speciality_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Specialities", t => t.Speciality_Id, cascadeDelete: true)
                .Index(t => t.Name, unique: true)
                .Index(t => t.Speciality_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Lastname = c.String(nullable: false, maxLength: 50),
                        Patronymic = c.String(nullable: false, maxLength: 50),
                        Birthday = c.DateTime(nullable: false),
                        Address = c.String(nullable: false, maxLength: 1024),
                        Email = c.String(maxLength: 100),
                        TIN = c.String(nullable: false, maxLength: 12),
                        PassportSeria = c.String(nullable: false, maxLength: 4),
                        PassportNumber = c.String(nullable: false, maxLength: 6),
                        PhoneNumber = c.String(maxLength: 20),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => new { t.Name, t.Lastname })
                .Index(t => new { t.PassportNumber, t.PassportSeria }, unique: true)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.Inhabitancies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Room = c.Int(nullable: false),
                        Begin = c.DateTime(nullable: false),
                        End = c.DateTime(),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cost = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Inhabitancies", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Students", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Groups", "Speciality_Id", "dbo.Specialities");
            DropForeignKey("dbo.Specialities", "Faculty_Id", "dbo.Faculties");
            DropIndex("dbo.Payments", new[] { "Student_Id" });
            DropIndex("dbo.Inhabitancies", new[] { "Student_Id" });
            DropIndex("dbo.Students", new[] { "GroupId" });
            DropIndex("dbo.Students", new[] { "PassportNumber", "PassportSeria" });
            DropIndex("dbo.Students", new[] { "Name", "Lastname" });
            DropIndex("dbo.Groups", new[] { "Speciality_Id" });
            DropIndex("dbo.Groups", new[] { "Name" });
            DropIndex("dbo.Specialities", new[] { "Faculty_Id" });
            DropIndex("dbo.Specialities", new[] { "Code" });
            DropTable("dbo.Payments");
            DropTable("dbo.Inhabitancies");
            DropTable("dbo.Students");
            DropTable("dbo.Groups");
            DropTable("dbo.Specialities");
            DropTable("dbo.Faculties");
        }
    }
}
