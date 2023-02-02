
using POO.Controllers;
using POO.Models;

//Clases del modelo para obtener los datos: Producto, Venta, ProductoVenta, Usuario
//Métodos implementando ADO.NET:

//   RESULTADO DESAFIO: 


//Traer Usuario(recibe un int)

Console.WriteLine("Bienvenido, ingrese el Id del usuario: ");
long usuarioId = int.Parse(Console.ReadLine());
Usuario usuarioPorId = UsuarioController.GetUsuario(usuarioId);
Console.WriteLine("---------------------------");
Console.WriteLine(usuarioPorId.ToString());

//-----------------------------------------------


//Traer Productos(recibe un id de usuario y, devuelve una lista con todos los productos cargado por ese usuario)

Console.WriteLine("Ingresa el Id del Usuario para traer los pruductos cargados");
var idUsuario = int.Parse(Console.ReadLine());
var listaProductos = ProductoController.GetProductosbyId(idUsuario);
foreach (var product in listaProductos)
{
    Console.WriteLine(product.Descripciones);
}


//-----------------------------------------------

//Traer ProductosVendidos(recibe el id del usuario y devuelve una lista de productos vendidos por ese usuario) 

Console.WriteLine("Ingresa el id de la venta para traer el resumen de productos vendidos por ID");

var idVenta = int.Parse(Console.ReadLine());
var listaProductosVendidos = ProductoVendidoController.GetProductoVendido(idVenta);

foreach (var item in listaProductosVendidos)
{
    Console.WriteLine(item.Id);
}
//-----------------------------------------------


//Traer Ventas(recibe el id del usuario y devuelve un a lista de Ventas realizadas por ese usuario)

Console.WriteLine("Indica el id de usuario para traer susu ventas:");
var id = int.Parse(Console.ReadLine());
var listaVentas = VentaController.GetVentas(id);

foreach (var item in listaVentas)
{
    Console.WriteLine(item.Id);
}




//-----------------------------------------------

//Inicio de sesión (recibe un usuario y contraseña y devuelve un objeto Usuario) X

Console.WriteLine("Bienvenido, ingrese usuario: ");
var nombreUsuario = Console.ReadLine();
Console.WriteLine("---------------------------");
Console.WriteLine("Ingrese su contraseña: ");
var constrasenia = Console.ReadLine();
Console.WriteLine("-------------------------");
Usuario usuarioSeleccionado = UsuarioController.GetUsuario(nombreUsuario, constrasenia);
Console.WriteLine("---------------------------");
Console.WriteLine(usuarioSeleccionado.ToString());