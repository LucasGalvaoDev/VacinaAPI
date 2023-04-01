using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Model
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public DateTime DataSolicitacao {get;set;}
    }
}
