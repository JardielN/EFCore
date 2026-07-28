

public class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; }

    // Llave foranea para la relacion
    public int WorkOrderId { get; set; }
    // Navegacion inversa
    public WorkOrder workOrder { get; set; }
}