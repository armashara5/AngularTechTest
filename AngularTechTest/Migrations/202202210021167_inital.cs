namespace MVCTestappWithDotNstFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeETasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        ETaskId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.ETasks", t => t.ETaskId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.ETaskId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Department = c.String(),
                        Salary = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.ETasks",
                c => new
                    {
                        ETaskId = c.Int(nullable: false, identity: true),
                        TaskName = c.String(),
                    })
                .PrimaryKey(t => t.ETaskId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeETasks", "ETaskId", "dbo.ETasks");
            DropForeignKey("dbo.EmployeeETasks", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.EmployeeETasks", new[] { "ETaskId" });
            DropIndex("dbo.EmployeeETasks", new[] { "EmployeeId" });
            DropTable("dbo.ETasks");
            DropTable("dbo.Employees");
            DropTable("dbo.EmployeeETasks");
        }
    }
}
