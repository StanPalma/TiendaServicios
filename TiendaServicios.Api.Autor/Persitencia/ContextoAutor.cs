using Microsoft.EntityFrameworkCore;
using TiendaServicios.Api.Autor.Modelo;

namespace TiendaServicios.Api.Autor.Persitencia
{
    public class ContextoAutor:DbContext
    {
        public ContextoAutor(DbContextOptions<ContextoAutor> options) : base(options) { }
        public DbSet<AutorLibro> AutorLibro { get; set; }
        public DbSet<GradoAcademico> GradoAcademico { get; set; }
    }
}
