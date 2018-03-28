using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebConsultasv10.Models
{
    [Table("Funcionarios")]
    public class Funcionarios
    {
        [Key]
        public int IdFuncionario { get; set; }

        [DisplayName("Nome Funcionário")]
        public string Nome { get; set; }

        [DisplayName("Salário")]
        public decimal Salario { get; set; }

        public bool Ativo { get; set; }


    }
}