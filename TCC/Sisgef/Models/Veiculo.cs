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
        public int Id { get; set; }
    }
    public class Veiculo : BaseModel
    {

        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "É necessário preencher a placa")]
        [DisplayName("Placa")]
        public string Placa { get; set; }

        [Column(TypeName = "varchar(20)")]
        [DisplayName("Renavam")]
        public string Renavam { get; set; }

        [Column(TypeName = "varchar(25)")]
        [DisplayName("Marca")]
        public string Marca { get; set; }

        [Column(TypeName = "varchar(30)")]
        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        [Column(TypeName = "varchar(20)")]
        [DisplayName("Cor")]
        public string Cor { get; set; }
        [Column(TypeName = "varchar(30)")]
        [DisplayName("Chassi")]
        public string Chassi { get; set; }

        [Column(TypeName = "varchar(30)")]
        [DisplayName("Tipo do Veículo")]
        public string TipoDoVeiculo { get; set; }

        [Column(TypeName = "varchar(30)")]
        [DisplayName("Tipo de carroceria")]
        public string TipoCarroceria { get; set; }

        [Column(TypeName = "varchar(15)")]
        [DisplayName("Ano Fabricação")]
        public string AnoFabricacao { get; set; }

        [Column(TypeName = "varchar(20)")]
        [DisplayName("Odômetro")]
        public string Odometro { get; set; }

        [Column(TypeName = "varchar(20)")]
        [DisplayName("Combustível")]
        public string Combustivel { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Nome do proprietário")]
        public string NomeDoProprietario { get; set; }

        [Column(TypeName = "varchar(25)")]
        [DisplayName("Documento do proprietário")]
        public string DocumentoDoProprietario { get; set; }

        [Column(TypeName = "varchar(30)")]
        [DisplayName("Local de emplacamento")]
        public string LocalDeEmplacamento { get; set; }

        [Column(TypeName = "varchar(50)")]
        [DisplayName("Observação")]
        public string Observacao { get; set; }

       


    }

}
