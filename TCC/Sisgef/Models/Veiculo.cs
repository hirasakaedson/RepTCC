using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sisgef.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string TipoDoVeiculo { get; set; }
        public string TipoCarroceria { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public int Odometro { get; set; }
        public double Combustivel { get; set; }
        public string NomeDoProprietario { get; set; }
        public int DocumentoDoProprietario { get; set; }
        public string LocalDeEmplacamento { get; set; }
        public DateTime MesDoSeguro { get; set; }
        public string Observacao { get; set; }
        public int QuantidadeDeEixos { get; set; }
        public int Renavam { get; set; }
        public string Seguradora { get; set; }
    }
}
