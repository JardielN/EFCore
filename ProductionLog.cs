public class ProductionLog
{
    public int ProductionLogId { get; set; } // Clave Primaria
    public int QuantityProduced { get; set; }
    public string Shift { get; set; } // Ejemplo: "Matutino", "Vespertino"
    public DateTime LogTimestamp { get; set; }

    // Clave foranea que apunta a la orden padre
    public int WorkOrderId { get; set; }

    // Propiedad de navegacion: el registro pertenece a UNA orden
    public WorkOrder WorkOrder { get; set; }
}