namespace CBYK.Api.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserEntities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO dbo.UserEntities(UserName,Password) Values('teste','teste')");

        }
        
        public override void Down()
        {
            DropTable("dbo.UserEntities");
        }
    }
}
