
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vacinacoes.API.Model;
using Vacinacoes.API.Repositories;

namespace Vacinacoes.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VacinaController : ControllerBase
    {
        private readonly IConsultaRepository _consultaRepository;

        public VacinaController(ILogger<VacinaController> logger, IConsultaRepository consultaRepository)
        {
            _consultaRepository = consultaRepository;
        }

        [HttpGet]
        public async Task<Relatorio> Get(string nome, string cpf, string data)
        {
            return await _consultaRepository.Get(nome, cpf, data);
        }
    }
}
