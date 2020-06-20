using System;
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

        [Column(TypeName = "varchar(20)")]
        [DisplayName("Data")]
        public DateTime Data { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Emissor")]
        public string UsuarioEmissor { get; set; }
        //tem que criar enum
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Tipo de serviço")]
        public string TipoDeServico { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Observação")]
        public string Observacao { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Motorista")]
        public string Motorista { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Valor")]
        public decimal Valor { get; set; }

        [Column(TypeName = "varchar(50)")]
        
        public virtual Veiculo Veiculo { get; set; }
        [ForeignKey("Veiculo")]
        [DisplayName("Veiculo")]
        public int VeiculoId { get; set; }


        [Column(TypeName = "varchar(50)")]
       
        public virtual Fornecedor Fornecedor { get; set; }
        [ForeignKey("Fornecedor")]
        [DisplayName("Fornecedor")]
        public int FornecedorId { get; set; }

        

    }
}
