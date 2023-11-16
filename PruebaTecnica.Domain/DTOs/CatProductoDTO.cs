using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Domain.DTOs
{
    public class CatProductoDTO
    {
        public int Id { get; set; }

        public string NombreProducto { get; set; } = null!;

        public byte[]? ImagenProducto { get; set; }

        public decimal PrecioUnitario { get; set; }

        public string? Ext { get; set; }
    }
}
