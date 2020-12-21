using Agenda.Dominio.Contratos;
using Agenda.Dominio.Entity;
using Agenda.Repository.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.Web.Controllers
{
    [Route("api/[controller]")]
    public class PessoaController : Controller
    {
        private readonly IPessoaRepository pessoaRepository ;
        public PessoaController(IPessoaRepository _pessoaRepository)
        {
            pessoaRepository = _pessoaRepository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(Pessoa pessoa)
        {
            try
            {   
                pessoaRepository.Add(pessoa);
                return Created("api/pessoa", pessoa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
