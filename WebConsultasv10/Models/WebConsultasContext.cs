using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebConsultasv10.Migrations;

namespace WebConsultasv10.Models
{
    public class WebConsultasContext : DbContext
    {
        public WebConsultasContext() : base("WebConsultas")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<WebConsultasContext, Configuration>());
        }
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Empresas> Empresas { get; set; }

    }
}