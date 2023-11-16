using System;
using System.Collections.Generic;

namespace PruebaTecnica.Domain.Models;

public partial class CatProducto
{
    public int Id { get; set; }

    public string NombreProducto { get; set; } = null!;

    public byte[]? ImagenProducto { get; set; }

    public decimal PrecioUnitario { get; set; }

    public string? Ext { get; set; }

    public virtual ICollection<TblDetallesFactura> TblDetallesFacturas { get; set; } = new List<TblDetallesFactura>();
}
