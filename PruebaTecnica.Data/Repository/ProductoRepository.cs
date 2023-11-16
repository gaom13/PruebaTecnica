using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Data.Context;
using PruebaTecnica.Domain.DTOs;
using PruebaTecnica.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Data.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly LabDevContext labDevContext;
        private readonly IMapper mapper;

        public ProductoRepository(LabDevContext labDevContext, IMapper mapper)
        {
            this.labDevContext = labDevContext;
            this.mapper = mapper;
        }

        public async Task<List<CatProductoDTO>> GetProductos()
        {
            var productos = await labDevContext.CatProductos.ToListAsync();
            var productosDTO = mapper.Map<List<CatProductoDTO>>(productos);

            return productosDTO;
        }
    }
}
