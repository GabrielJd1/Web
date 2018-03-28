namespace WebConsultasv10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teste : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        IdEmpresa = c.Int(nullable: false, identity: true),
                        Cnpj = c.Long(nullable: false),
                        NomeFan = c.String(),
                        NomeRazao = c.String(),
                    })
                .PrimaryKey(t => t.IdEmpresa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empresas");
        }
    }
}
