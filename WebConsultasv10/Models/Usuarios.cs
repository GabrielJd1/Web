using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebConsultasv10.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nick { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        [ForeignKey("Funcionarios")]
        public int IdFuncionario { get; set; }

        public virtual Funcionarios Funcionarios { get; set; }
    }
}