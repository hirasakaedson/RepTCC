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
        //public string TipoDoVeiculo { get; set; }
        //public string TipoCarroceria { get; set; }
        //public DateTime AnoFabricacao { get; set; }
        //public int Odometro { get; set; }
        //public double Combustivel { get; set; }
        //public string NomeDoProprietario { get; set; }
        //public int DocumentoDoProprietario { get; set; }
        //public string LocalDeEmplacamento { get; set; }
        //public DateTime MesDoSeguro { get; set; }
        //public string Observacao { get; set; }
        //public int QuantidadeDeEixos { get; set; }
        //public int Renavam { get; set; }
        //public string Seguradora { get; set; }
    }
}
