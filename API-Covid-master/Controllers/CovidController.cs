using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trabalho_A.P.I___COVID.Models;

namespace Trabalho_A.P.I___COVID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Listagem de todos os pacientes");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Listagem do paciente específico");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Covid covid)
        {
            return Ok("Cadastro efetuado com Sucesso");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id)
        {
            return Ok("Alterações realizadas com Sucesso");
        } 
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok("Usuário deletado");
        } 

    }
}
