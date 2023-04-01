using BookAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vacinacoes.API.Model
{
    public class ConsultaContext : DbContext
    {
        public ConsultaContext(DbContextOptions<ConsultaContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Relatorio> Relatorio { get; set; }
    }
}
