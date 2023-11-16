using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Application.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnica.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        // GET: api/<ClienteController>
        [HttpGet("obtenerClientes")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await clienteService.GetClientes());
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
