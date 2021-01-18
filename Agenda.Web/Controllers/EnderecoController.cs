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
    public class EnderecoController : Controller
    {
        private readonly IEnderecoRepository enderecoRepository ;
        public EnderecoController(IEnderecoRepository _enderecoRepository)
        {
            enderecoRepository = _enderecoRepository;
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
        public IActionResult Post(Endereco endereco)
        {
            try
            {   
                enderecoRepository.Add(endereco);
                return Created("api/pessoa", endereco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
