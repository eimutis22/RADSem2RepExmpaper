namespace RADSem2RepExam.Migrations.StudentMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        AttendanceID = c.Int(nullable: false, identity: true),
                        ModuleID = c.Int(nullable: false),
                        StudentID = c.String(maxLength: 128),
                        AttendanceDateTime = c.DateTime(nullable: false, storeType: "date"),
                        Present = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AttendanceID)
                .ForeignKey("dbo.Modules", t => t.ModuleID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID)
                .Index(t => t.ModuleID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        ModuleID = c.Int(nullable: false, identity: true),
                        ModuleName = c.String(),
                    })
                .PrimaryKey(t => t.ModuleID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Attendances", "ModuleID", "dbo.Modules");
            DropIndex("dbo.Attendances", new[] { "StudentID" });
            DropIndex("dbo.Attendances", new[] { "ModuleID" });
            DropTable("dbo.Students");
            DropTable("dbo.Modules");
            DropTable("dbo.Attendances");
        }
    }
}
