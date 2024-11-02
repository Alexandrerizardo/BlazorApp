using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vendedores.Models
{
    public class Regiao
    {
        
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Favor informar a região.")]
        [MinLength(2, ErrorMessage = "A região precisa ter ao menos dois caracteres")]
        [MaxLength(20, ErrorMessage = "A região só pode conter até 20 caracteres.")]
        public string Nome { get; set; }
    }
}