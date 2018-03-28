namespace WebConsultasv10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Empresas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "IdEmpresa", c => c.Int(nullable: false));
            CreateIndex("dbo.Usuarios", "IdEmpresa");
            AddForeignKey("dbo.Usuarios", "IdEmpresa", "dbo.Empresas", "IdEmpresa", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "IdEmpresa", "dbo.Empresas");
            DropIndex("dbo.Usuarios", new[] { "IdEmpresa" });
            DropColumn("dbo.Usuarios", "IdEmpresa");
        }
    }
}
