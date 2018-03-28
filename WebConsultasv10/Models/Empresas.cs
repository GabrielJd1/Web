using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebConsultasv10.Models
{
    [Table("Empresas")]
    public class Empresas
    {
        [Key]
        public int IdEmpresa { get; set; }
        
        public Int64 Cnpj { get; set; }

        public string NomeFan { get; set; }

        public string NomeRazao { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }

    }
}