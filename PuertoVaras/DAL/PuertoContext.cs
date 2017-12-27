using PuertoVaras.Models;
using System.Data.Entity;

namespace PuertoVaras.DAL
{
    public class PuertoContext: DbContext
    {
        public PuertoContext() : base("KeyPuertoDB")
        { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}