namespace BTL_QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.String(nullable: false, maxLength: 128, unicode: false),
                        PesonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
        }
    }
}
