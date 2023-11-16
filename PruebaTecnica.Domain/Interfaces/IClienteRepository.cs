using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task<List<TblCliente>> GetClientes();
    }
}
