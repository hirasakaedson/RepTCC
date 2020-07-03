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

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "É necessário preencher o Email")]
        [DisplayName("Email")]
        public string Email { get; set; }


        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "É necessário preencher o CPF/CNPJ")]
        [DisplayName("CPF/CNPJ")]
        public string CpfCnpj { get; set; }


        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "É necessário preencher o nome do responsável")]
        [DisplayName("Nome/Razão social")]
        public string Nome { get; set; }


        [Column(TypeName = "varchar(50)")]
        [DisplayName("Observações")]
        public string Observacao { get; set; }


        [Column(TypeName = "varchar(15)")]
        [Required(ErrorMessage = "É necessário preencher o contato")]
        [DisplayName("Contato")]
        public string Contato { get; set; }


        [Column(TypeName = "varchar(15)")]
        [DisplayName("Contato")]
        public string Contato2 { get; set; }


        [Column(TypeName = "varchar(3)")]
        [DisplayName("É posto de combustível?")]
        public string Posto { get; set; }


        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "É necessário preencher a Rua")]
        [DisplayName("Rua")]
        public string Rua { get; set; }


        [Column(TypeName = "varchar(6)")]
        [Required(ErrorMessage = "É necessário preencher o número")]
        [DisplayName("Número")]
        public string Numero { get; set; }


        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "É necessário preencher o Bairro")]
        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        public virtual List<Requisicao> Requisicoes { get; set; }
    }

}
