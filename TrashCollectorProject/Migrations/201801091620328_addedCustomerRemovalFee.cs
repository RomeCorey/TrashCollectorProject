namespace TrashCollectorProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCustomerRemovalFee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "removalFee", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "removalFee");
        }
    }
}
