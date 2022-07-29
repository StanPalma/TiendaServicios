using AutoMapper;
using TiendaServicios.Api.Autor.Modelo;

namespace TiendaServicios.Api.Autor.Aplicacion
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AutorLibro, AutorDTO>();
        }
    }
}
