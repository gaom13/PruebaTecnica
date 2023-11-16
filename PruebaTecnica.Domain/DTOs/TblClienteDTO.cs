using PruebaTecnica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Domain.DTOs
{
    public class TblClienteDTO
    {
        public int Id { get; set; }

        public string RazonSocial { get; set; } = null!;

        public int IdTipoCliente { get; set; }

        public string Rfc { get; set; } = null!;

        public virtual CatTipoClienteDTO IdTipoClienteNavigation { get; set; } = null!;
    }
}
