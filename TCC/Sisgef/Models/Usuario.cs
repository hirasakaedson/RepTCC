using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sisgef.Models
{
    public class Usuario
    {
        
        [Required(ErrorMessage ="O Login deve ser inserido")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O Login deve ser inserido")]
        public string Senha { get; set; }
    }
}
