using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Data.Context;
using PruebaTecnica.Domain.DTOs;
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
        private readonly IMapper mapper;

        public ClienteRepository(LabDevContext labDevContext, IMapper mapper)
        {
            this.labDevContext = labDevContext;
            this.mapper = mapper;
        }

        public async Task<List<TblClienteDTO>> GetClientes()
        {
            try
            {
                var clientes = await labDevContext.TblClientes
                    .Include(x => x.IdTipoClienteNavigation)
                    .ToListAsync();
                var clientesDTO = mapper.Map<List<TblClienteDTO>>(clientes);
                return clientesDTO;
            }
            catch (Exception ex)
            {
                return new List<TblClienteDTO>();
            }
        }
    }
}
