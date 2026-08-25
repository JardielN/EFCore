// Leer los datos de la base de datos
// Podemos usar LINQ para consultar lo que acabamos de guardar
using (var context = new PlantFlowDbContext())
{
    // Consultar todas las ordenes de produccion incluyendo
    // productos relacionados
    var listadeOrdenes = context.WorkOrders.ToList();

    Console.WriteLine("\n--- LISTA DE ORDENES EN PLANTA ---");
    foreach(var order in listadeOrdenes)
    {
        Console.WriteLine($"Orden: {order.OrderName} | Iniciada el: {order.StartDate}");
    }
}