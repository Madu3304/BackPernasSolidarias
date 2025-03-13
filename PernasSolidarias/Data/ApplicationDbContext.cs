using PernasSolidarias.Models;
using System.Data.Entity;
using Microsoft.EntityFramework.Core;

namespace PernasSolidarias.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<LoginModel> Usuarios { get; set; }
    }
}


//depois que tiver o banco execultar esse comando aqui: 
//dotnet ef migrations add CriarTabelaUsuarios
//dotnet ef database update
