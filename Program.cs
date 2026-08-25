// Paso 1: Insertar datos de prueba
/*
using (var context = new PlantFlowDbContext())
{
    // Crear una nueva orden de produccion con un producto
    var newOrder = new WorkOrder
    {
        OrderName = "WO-REYNOSA-001",
        StartDate = DateTime.Now,
        Product = new List<Product>
        {
            new Product {ProductName = "Arnes Electrico A-1"}
        }
    };

    // Decirle al contexto que agregue la orden
    context.WorkOrders.Add(newOrder);

    // Guardar los cambios fisicamente en SQL Server
    context.SaveChanges();
    Console.WriteLine("Orden y producto guardado exitosamente!");
}

*/