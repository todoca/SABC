using Microsoft.EntityFrameworkCore;
using SABC.Data.Entidades;

namespace SABC.Data.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ClientePagoDto>().HasNoKey();
        modelBuilder.Entity<Cliente>()
            .HasData(
            new Cliente
            {
                Id = 1,
                NombreCompleto = "Juan Perez",
                Cedula = "8-75-584",
                PIN = "1478",

            },
            new Cliente
            {
                Id = 2,
                NombreCompleto = "Miguel Batista",
                Cedula = "PE-254-845",
                PIN = "1244",
            });
        modelBuilder.Entity<Pago>()
        .HasData(
            new Pago()
            { Id = 1, ClienteId = 1, Cedula = "8-75-584", Fecha = new DateTime(2021, 04, 04), Monto = 200.00 },
            new Pago()
            { Id = 2, ClienteId = 1, Cedula = "8-75-584", Fecha = new DateTime(2021, 01, 05), Monto = 198.22 },
            new Pago()
            { Id = 3, ClienteId = 1, Cedula = "8-75-584", Fecha = new DateTime(2021, 01, 06), Monto = 210.00 },
            new Pago()
            { Id = 4, ClienteId = 2, Cedula = "PE-254-845", Fecha = new DateTime(2021, 04, 30), Monto = 200.00 },
            new Pago()
            { Id = 5, ClienteId = 2, Cedula = "PE-254-845", Fecha = new DateTime(2021, 03, 29), Monto = 198.22 },
            new Pago()
            { Id = 6, ClienteId = 2, Cedula = "PE-254-845", Fecha = new DateTime(2021, 02, 17), Monto = 210.00 }
        );
    }
    public DbSet<Cliente> Clientes { get; set; } = default!;
    public DbSet<Pago> Pagos { get; set; } = default!;
    public DbSet<ClientePagoDto> ClientePagos { get; set; } = default!;

}
