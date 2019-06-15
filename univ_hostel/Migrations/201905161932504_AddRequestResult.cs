namespace univ_hostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequestResult : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RequestResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Comment = c.String(),
                        Status = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RequestResults", "Student_Id", "dbo.Students");
            DropIndex("dbo.RequestResults", new[] { "Student_Id" });
            DropTable("dbo.RequestResults");
        }
    }
}
