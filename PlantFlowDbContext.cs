using Microsoft.EntityFrameworkCore;

// la clase heredara todo el poder de DbContext
public class PlantFlowDbContext : DbContext
{
    // La direccion y credenciales donde se guardaran la abse de datos
    private const string ConnectionString =
        @"Server=localhost;Database=Plantflow;Trusted_connection=true;TrustedServerCertificate=true;";

    // Decirle a EF Core que motor de base de datos usar
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
    }

    // Aqui registramos las tablas que EF Core va a crear en la base de datos
    public DbSet<WorkOrder> WorkOrders { get; set; }
    public DbSet<Product> Products { get; set; }
}