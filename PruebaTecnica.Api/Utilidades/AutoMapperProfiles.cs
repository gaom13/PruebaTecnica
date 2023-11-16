using AutoMapper;
using PruebaTecnica.Domain.DTOs;
using PruebaTecnica.Domain.Models;

namespace PruebaTecnica.Api.Utilidades
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<TblCliente, TblClienteDTO>().ReverseMap();
            CreateMap<CatTipoCliente, CatTipoClienteDTO>().ReverseMap();

            CreateMap<CatProducto, CatProductoDTO>().ReverseMap();
        }
    }
}
