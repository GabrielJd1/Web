namespace WebConsultasv10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        IdFuncionario = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdFuncionario);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        Nick = c.String(),
                        Senha = c.String(),
                        Email = c.String(),
                        IdFuncionario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario)
                .ForeignKey("dbo.Funcionarios", t => t.IdFuncionario, cascadeDelete: true)
                .Index(t => t.IdFuncionario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "IdFuncionario", "dbo.Funcionarios");
            DropIndex("dbo.Usuarios", new[] { "IdFuncionario" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Funcionarios");
        }
    }
}
