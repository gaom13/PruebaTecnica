﻿using PruebaTecnica.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Domain.Interfaces
{
    public interface IProductoRepository
    {
        Task<List<CatProductoDTO>> GetProductos();
    }
}
