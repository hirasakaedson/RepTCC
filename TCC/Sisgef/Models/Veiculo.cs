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
    public class BaseModel
    {
        [DataMember]
        [Key]
        public int Id { get; set; }
    }
    public class Veiculo : BaseModel
    {



        [Column(TypeName = "varchar(13)")]
        [Required(ErrorMessage = "É necessário preencher o Renavam")]
        [DisplayName("Renavam")]
        public string Renavam { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "É necessário preencher o nome do proprietário")]
        [DisplayName("Nome do proprietário")]
        public string NomeDoProprietario { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "É necessário preencher o documento do proprietário")]
        [DisplayName("Documento do proprietário")]
        public string CpfCnpj { get; set; }

        [Column(TypeName = "varchar(7)")]
        [Required(ErrorMessage = "É necessário preencher a placa")]
        [DisplayName("Placa")]
        public string Placa { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "É necessário preencher o chassi")]
        [DisplayName("Chassi")]
        public string Chassi { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "É necessário preencher o tipo de veiculo")]
        [DisplayName("Tipo do Veículo")]
        public string TipoDoVeiculo { get; set; }

        [Required(ErrorMessage = "É necessário preencher tipo de combustível")]
        [Column(TypeName = "varchar(15)")]
        [DisplayName("Combustível")]
        public string Combustivel { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "É necessário preencher a marca")]
        [DisplayName("Marca")]
        public string Marca { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "É necessário preencher o modelo")]
        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        [Column(TypeName = "varchar(4)")]
        [Required(ErrorMessage = "É necessário preencher o ano de fabricação")]
        [DisplayName("Ano Fabricação")]
        public string AnoFabricacao { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "É necessário preencher o tipo de carroceria")]
        [DisplayName("Tipo de carroceria")]
        public string TipoCarroceria { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "É necessário preencher a cor")]
        [DisplayName("Cor")]
        public string Cor { get; set; }

        [Column(TypeName = "varchar(7)")]
        [Required(ErrorMessage = "É necessário preencher o odômetro")]
        [DisplayName("Odômetro")]
        public string Odometro { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Observação")]
        public string Observacao { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "É necessário preencher o local de emplacamento")]
        [DisplayName("Local de emplacamento")]
        public string LocalDeEmplacamento { get; set; }

        public virtual List<Requisicao> Requisicoes { get; set; }




    }

}
