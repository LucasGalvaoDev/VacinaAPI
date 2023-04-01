using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vacinacoes.API.Model
{
    public class Relatorio
    {
        public int Id { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string DescricaoRelatorio { get; set; }
        public int QuantidadeTotalVacinados { get; set; }
        public string Solicitante { get; set; }
    }
}
