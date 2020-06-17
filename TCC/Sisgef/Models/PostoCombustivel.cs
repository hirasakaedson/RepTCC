using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Sisgef.Models
{
    
    public class PostoCombustivel
    {
        [DataMember]
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "É necessário preencher a placa")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(20)")]
        [DisplayName("Bandeira")]
        public string Bandeira { get; set; }

        [Column(TypeName = "varchar(25)")]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [Column(TypeName = "varchar(30)")]
        [DisplayName("Rua")]
        public string Rua { get; set; }

        [Column(TypeName = "varchar(30)")]
        [DisplayName("Número")]
        public string Numero { get; set; }

        [Column(TypeName = "varchar(30)")]
        [DisplayName("Bairro")]
        public string Bairro { get; set; }


    }

}
