using System.Collections.Generic;
public class Operator
{
    public int OperatorId { get; set; }
    public string FullName { get; set; }
    public string Shift { get; set; }

    // Relacion Muchos a Muchos: Un operador puede estar
    // asignado a muchas estaciones de trabajo
    public ICollection<WorkStation> WorkStations { get; set; } = new List<WorkStation>();
}