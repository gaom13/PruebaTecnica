using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Data.Context;
using PruebaTecnica.Domain.Interfaces;
using PruebaTecnica.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly LabDevContext labDevContext;

        public ClienteRepository(LabDevContext labDevContext)
        {
            this.labDevContext = labDevContext;
        }

        public async Task<List<TblCliente>> GetClientes()
        {
            try
            {
                return await labDevContext.TblClientes.ToListAsync();
            }
            catch (Exception ex)
            {
                return new List<TblCliente>();
            }
        }
    }
}
