

public class WorkOrder
{
    public int WorkOrderId { get; set; }

    public string OrderName { get; set; }
    public DateTime StartDate { get; set; }

    public List<Product> Product { get; set; } = new();

    // Propiedad de navegacion: UNA orden tiene UN reporte
    // de inspeccion
    public QualityInspection QualityInspection { get; set; }

    // Relacion de uno a Varios: UNA orden tiene MUCHOS registros
    // de produccion
    public ICollection<ProductionLog> ProductionLogs { get; set; } = new List<ProductionLog>();
}