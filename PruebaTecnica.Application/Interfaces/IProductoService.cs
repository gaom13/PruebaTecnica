using PruebaTecnica.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Application.Interfaces
{
    public interface IProductoService
    {
        Task<List<CatProductoDTO>> GetProductos();
    }
}
