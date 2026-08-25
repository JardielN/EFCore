using System.Collections.Generic;
public class WorkStation
{
    public int WorkStationId { get; set; }
    public string StationName { get; set; } // Ejemplo: "Linea de ensamble A", "Estacion de Soldadura"
    public string Area { get; set; }

    // Relacion Muchos a Muchos: Una estacion puede tener muchos operadores asignados
    public ICollection<Operator> Operators { get; set; } = new List<Operator>();
}