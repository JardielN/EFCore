using Microsoft.EntityFrameworkCore;

// la clase heredara todo el poder de DbContext
public class PlantFlowDbContext : DbContext
{
    // La direccion y credenciales donde se guardaran la abse de datos
    private const string ConnectionString =
    @"Server=localhost;Database=PlantFlow;Trusted_Connection=True;Encrypt=False;";

    // Decirle a EF Core que motor de base de datos usar
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Si el servidor tarda un segundo en guardar por primera vez
        // reintentalo automaticamente
        optionsBuilder.UseSqlServer(ConnectionString, x=> x.EnableRetryOnFailure());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // configurando la relacion Uno a Uno entre WorkOrder y QualityInspection
        modelBuilder.Entity<WorkOrder>()
            .HasOne(w => w.QualityInspection) // Una WorkOrder tiene una QualityInspection
            .WithOne(q => q.WorkOrder) // una QualityInspection tiene una WorkOrder 
            .HasForeignKey<QualityInspection>(q => q.WorkOrderId); // usando WorkOrderId como enlace

        // Configuracion de la relacion uno a Varios
        modelBuilder.Entity<WorkOrder>()
            .HasMany(w => w.ProductionLogs) // Una WorkOrder tiene muchos ProductLogs
            .WithOne(p => p.WorkOrder) // Un ProductionLog pertenece a una WorkOrder
            .HasForeignKey(p => p.WorkOrderId); // usando WorkOrderId

        // Configuracion de la relacion Muchos a Muchos
        modelBuilder.Entity<Operator>()
            .HasMany(o => o.WorkStations)
            .WithMany(w => w.Operators);
    }

    // Aqui registramos las tablas que EF Core va a crear en la base de datos
    public DbSet<WorkOrder> WorkOrders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Operator> Operators { get; set; }
    public DbSet<WorkStation> WorkStations { get; set; }
}