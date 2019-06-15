namespace univ_hostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifyRequestResult : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.RequestResults", name: "Student_Id", newName: "StudentId");
            RenameIndex(table: "dbo.RequestResults", name: "IX_Student_Id", newName: "IX_StudentId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.RequestResults", name: "IX_StudentId", newName: "IX_Student_Id");
            RenameColumn(table: "dbo.RequestResults", name: "StudentId", newName: "Student_Id");
        }
    }
}
