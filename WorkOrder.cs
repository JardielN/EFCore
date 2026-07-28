

public class WorkOrder
{
    public int WorkOrderId { get; set; }

    public string OrderName { get; set; }
    public DateTime StartDate { get; set; }

    public List<Product> Product { get; set; } = new();
}