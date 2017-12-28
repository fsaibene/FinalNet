namespace PuertoVaras.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ID_CLIENTE = c.Int(nullable: false, identity: true),
                        NOMBRE = c.String(maxLength: 20),
                        TIPO_CLIENTE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_CLIENTE);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
