using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Application.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnica.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService productoService;

        public ProductoController(IProductoService productoService)
        {
            this.productoService = productoService;
        }

        // GET: api/<ProductoController>
        [HttpGet("obtenerProductos")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await productoService.GetProductos());
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
