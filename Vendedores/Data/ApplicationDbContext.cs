using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vendedores.Models;

namespace Vendendores.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Regiao> Regioes { get; set; }
    public DbSet<Vendedor> Vendedores { get; set; }
}
