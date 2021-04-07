using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1.Models
{
    public class Categoria
    {
    public int Id { get; set; }
        [Required(ErrorMessage = "Descrição Obrigatória")]
        [Display(Name = "Descrição")]
        public string descricao { get; set; }
       // public List<Produto> Produtos { get; set; }
    
    }
}
