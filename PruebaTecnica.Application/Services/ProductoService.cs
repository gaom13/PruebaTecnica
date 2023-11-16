using PruebaTecnica.Application.Interfaces;
using PruebaTecnica.Domain.DTOs;
using PruebaTecnica.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Application.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository productoRepository;

        public ProductoService(IProductoRepository productoRepository)
        {
            this.productoRepository = productoRepository;
        }

        public async Task<List<CatProductoDTO>> GetProductos()
        {
            return await productoRepository.GetProductos();
        }
    }
}
