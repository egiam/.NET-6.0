
using EF_DatabaseFirst.Models;
using EFDatabaseFirs.Namespace;
using Microsoft.EntityFrameworkCore;

var ctx = new NorthwindContext();

//Agregar
var newCustomer = new Customer()
{
    CustomerId = "RUBEN",
    CompanyName = "Ruben Benegas",
    Orders = new List<Order>()
};

newCustomer.Orders.Add(new Order()
{
    CustomerId = "RUBEN",
    OrderDate = DateTime.Now
});

ctx.Add(newCustomer);
ctx.SaveChanges();

//Editar
var reg = ctx.Customers.FirstOrDefault(r => r.CustomerId == "RUBEN");
if (reg != null)
{
    reg.CompanyName = "Ruben Benegas Editado";
    ctx.SaveChanges();
}

//Eliminar
var regOrders = ctx.Orders.Where(r => r.CustomerId == "RUBEN");
ctx.RemoveRange(regOrders);
var regCustomer = ctx.Customers.FirstOrDefault(r => r.CustomerId == "RUBEN");
ctx.Remove(regCustomer);



Console.WriteLine("Lista de Customers");
Console.WriteLine();
Console.WriteLine("==========================================");
var customers = ctx.Customers.Select(selector => new
{
    IdCustomer = selector.CustomerId,
    NameCustomer = selector.CompanyName
});
// Es una ventaja xq sirve para mejorar el rendimiento del programa. Gasta menos recursos. No traer informacion redundante (no utilizada).
// Mejora la seguridad al no traer extra info.

//var sql = ctx.Customers.FromSqlRaw("SELECT * FROM Customers"); //SQL Crudo.

foreach (var customer in customers)
{
    Console.WriteLine($"{customer.IdCustomer} - {customer.NameCustomer}");
}

Console.WriteLine("==========================================");
Console.WriteLine();
Console.Write("Ingrese el IDCustomer que desea consultar: ");
string idCustomer = Console.ReadLine();

bool anyCustomer = ctx.Customers.Any(selector => selector.CustomerId == idCustomer.ToUpper()); // Si el Id ingresado es igual a algun CustomerID existente, dar True

if (anyCustomer)
{
    Console.WriteLine("Existe el customer");
    
    var customer = ctx.Customers.Include(i => i.Orders)
        .FirstOrDefault(selector => selector.CustomerId == idCustomer.ToUpper());
    
    Console.WriteLine();
    Console.WriteLine($"IDCustomer: {customer.CustomerId} - Company Name: {customer.CompanyName}");
    Console.WriteLine();
    Console.WriteLine("Orders");
    
    foreach (var order in customer.Orders)
    {
        Console.WriteLine($"OrderID: {order.OrderId} - Order Date: {order.OrderDate}");
    }
    
    Console.WriteLine("==========================================");
    Console.WriteLine();
}
else
{
    Console.WriteLine("No existe el customer");
}

var a = 1;
