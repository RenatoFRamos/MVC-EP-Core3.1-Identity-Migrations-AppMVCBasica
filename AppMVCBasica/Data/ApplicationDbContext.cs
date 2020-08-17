using AppMVCBasica.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppMVCBasica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Produto> Enderecos { get; set; }
        public DbSet<Fornecedor> Forcenedores { get; set; }
        public DbSet<Endereco> Produtos { get; set; }
    }
}
