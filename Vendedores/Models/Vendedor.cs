using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vendedores.Models
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Favor informar o nome do vendedor.")]
        [MinLength(2, ErrorMessage = "O nome do vendedor precisa ter ao menos dois caracteres")]
        [MaxLength(20, ErrorMessage = "O nome do vendedor só pode conter até 50 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Insira a idade do vendedor.")]
        public int Idade { get; set; }

        [EmailAddress(ErrorMessage = "O email não é válido.")]
        public string Email { get; set; }

        public Regiao Regiao { get; set; }
        //FK de regiao dentro da entidade vendedor
        public int RegiaoId { get; set; }
    }
}