using MVCProductoProveedor.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace MVCProductoProveedor.Models
{
    public class Context : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
