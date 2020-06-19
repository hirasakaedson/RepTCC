using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sisgef.Models
{
    public class Requisicao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string UsuarioEmissor { get; set; }
        //tem que criar enum
        public string TipoDeServico { get; set; }
        public string Observacao { get; set; }
        public string Motorista { get; set; }
        public decimal Valor { get; set; }
        public Veiculo ObjVeiculo { get; set; }
        public Fornecedor ObjFornecedor { get; set; }

    }
}
