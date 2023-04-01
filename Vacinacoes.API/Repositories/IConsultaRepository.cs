using BookAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vacinacoes.API.Model;

namespace Vacinacoes.API.Repositories
{
    public interface IConsultaRepository
    {
        Task<Relatorio> Get(string name, string cpf, string data);
    }
}
