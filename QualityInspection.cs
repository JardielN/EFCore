public class QualityInspection
{
    // Esta propiedad sera la clave Primaria y a la vez
    // clave foranea para WorkOrder
    public int QualityInspectionId { get; set; }

    public string InspectorName { get; set; }
    public bool PassedInspection { get; set; }
    public DateTime InspectionDate { get; set; }

    // Propiedad de navegacion inversa: el reporte pertenece
    // a UNA orden
    public int WorkOrderId { get; set; }
    public WorkOrder WorkOrder { get; set; }
}