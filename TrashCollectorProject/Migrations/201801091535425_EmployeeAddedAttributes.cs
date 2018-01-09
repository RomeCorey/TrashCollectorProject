namespace TrashCollectorProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeAddedAttributes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "UserName", c => c.String());
            AddColumn("dbo.Employees", "UserPassword", c => c.String());
            AddColumn("dbo.Employees", "City", c => c.String());
            AddColumn("dbo.Employees", "Zip", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Zip");
            DropColumn("dbo.Employees", "City");
            DropColumn("dbo.Employees", "UserPassword");
            DropColumn("dbo.Employees", "UserName");
        }
    }
}
