
using POO.Controllers;
using POO.Models;

List<Producto> lista = ProductoController.GetProductos();

foreach(var item in lista)
{
    Console.WriteLine(item.Descripciones);
}