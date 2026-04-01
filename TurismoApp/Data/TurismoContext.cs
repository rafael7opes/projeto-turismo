using Microsoft.EntityFrameworkCore;
using TurismoApp.Models;

namespace TurismoApp.Data
{
    // O DbContext é o gerente oficial entre o C# e o banco de dados
    public class TurismoContext : DbContext
    {
        public TurismoContext(DbContextOptions<TurismoContext> options) : base(options)
        {
        }

        // Transforma o molde "PontoTuristico" em uma tabela real no banco chamada "PontosTuristicos"
        public DbSet<PontoTuristico> PontosTuristicos { get; set; }
    }
}