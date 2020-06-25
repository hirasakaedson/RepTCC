﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sisgef.Models
{
    public class Requisicao
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "date")]
        [Required(ErrorMessage = "É necessário preencher a data")]
        [DisplayName("Data")]
        public DateTime Data { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "É necessário informar quem autorizou a requisição")]
        [DisplayName("Autorizado por")]
        public string Responsavel { get; set; }
        //tem que criar enum
        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "É necessário informar o tipo de serviço")]
        [DisplayName("Tipo de serviço")]
        public string TipoDeServico { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Observação")]
        public string Observacao { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "É necessário informar o motorista")]
        [DisplayName("Motorista")]
        public string Motorista { get; set; }

        [Column(TypeName = "varchar(15)")]
        [Required(ErrorMessage = "É necessário informar o valor")]
        [DisplayName("Valor")]
        public string Valor { get; set; }

        [Column(TypeName = "varchar(50)")]

        public virtual Veiculo Veiculo { get; set; }
        [ForeignKey("Veiculo")]
        [DisplayName("Veículo")]
        public int VeiculoId { get; set; }


        [Column(TypeName = "varchar(50)")]
        public virtual Fornecedor Fornecedor { get; set; }
        [ForeignKey("Fornecedor")]
        [DisplayName("Fornecedor")]
        public int FornecedorId { get; set; }



    }
}
