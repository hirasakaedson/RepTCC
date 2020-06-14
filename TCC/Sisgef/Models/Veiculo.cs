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
        [Required(ErrorMessage ="É necessário preencher a placa")]
        [DisplayName("Placa")]
        public string Placa { get; set; }
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Marca")]
        public string Marca { get; set; }
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Modelo")]
        public string Modelo { get; set; }
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Tipo do Veiculo")]
        public string TipoDoVeiculo { get; set; }
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Tipo de carroceria")]
        public string TipoCarroceria { get; set; }
        [Column(TypeName = "int")]
        [DisplayName("Ano Fabricacao")]
        public DateTime AnoFabricacao { get; set; }
        [Column(TypeName = "int")]
        [DisplayName("Odometro")]
        public int Odometro { get; set; }
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Combustivel")]
        public double Combustivel { get; set; }
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Nome do Proprietario")]
        public string NomeDoProprietario { get; set; }
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Documento do proprietário")]
        public int DocumentoDoProprietario { get; set; }
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Local de emplacamento")]
        public string LocalDeEmplacamento { get; set; }
        [Column(TypeName = "varchar(50)")]
        [DisplayName("Observação")]
        public string Observacao { get; set; }
        [Column(TypeName = "int")]
        [DisplayName("Quantidade de eixos")]
        public int QuantidadeDeEixos { get; set; }
        [Column(TypeName = "varchar(20)")]
        [DisplayName("Renavam")]
        public int Renavam { get; set; }
        [Column(TypeName = "varchar(20)")]
        
    }
}
