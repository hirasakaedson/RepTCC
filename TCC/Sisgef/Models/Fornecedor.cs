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
    
    public class Fornecedor
    {
        [DataMember]
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        [DisplayName("Tipo de serviço")]
        public string TipoDeServico { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Email")]
        public string Email { get; set; }


        [Column(TypeName = "varchar(20)")]
        [DisplayName("CPF/CNPJ")]
        public string CpfCnpj { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "É necessário preencher o nome do emissor")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Observações")]
        public string Observacoes { get; set; }

        [Column(TypeName = "varchar(15)")]
        [DisplayName("Contato")]
        public string Contato { get; set; }

        [Column(TypeName = "varchar(15)")]
        [DisplayName("Contato")]
        public string Contato2 { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Rua")]
        public string Rua { get; set; }

        [Column(TypeName = "varchar(6)")]
        [DisplayName("Número")]
        public string Numero { get; set; }

        [Column(TypeName = "varchar(20)")]
        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        public virtual List<Requisicao> Requisicoes { get; set; }
    }

}
