using ExampleEric.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ExampleEric.Data;

public class ClientDbContext : DbContext
{
    public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options)
    {
    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Address> Addresses { get; set; }
}
