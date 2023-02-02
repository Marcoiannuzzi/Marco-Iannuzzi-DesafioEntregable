
using POO.Controllers;
using POO.Models;

//Clases del modelo para obtener los datos: Producto, Venta, ProductoVenta, Usuario
//Métodos implementando ADO.NET:
//Traer Usuario(recibe un int)
//Traer Productos(recibe un id de usuario y, devuelve una lista con todos los productos cargado por ese usuario)
//Traer ProductosVendidos(recibe el id del usuario y devuelve una lista de productos vendidos por ese usuario) x
//Traer Ventas(recibe el id del usuario y devuelve un a lista de Ventas realizadas por ese usuario)
//Inicio de sesión (recibe un usuario y contraseña y devuelve un objeto Usuario)


Console.WriteLine("Bienvenido, ingrese usuario: ");
var nombreUsuario = Console.ReadLine();
Console.WriteLine("---------------------------");
Console.WriteLine("Ingrese su contraseña: ");
var constrasenia = Console.ReadLine();
Console.WriteLine("-------------------------");
Usuario usuarioSeleccionado = UsuarioController.GetUsuario(nombreUsuario,constrasenia);
Console.WriteLine("---------------------------");
Console.WriteLine(usuarioSeleccionado.ToString());


Console.WriteLine("Bienvenido, ingrese el Id del usuario: ");
long usuarioId = int.Parse(Console.ReadLine());
Usuario usuarioPorId = UsuarioController.GetUsuario(usuarioId);
Console.WriteLine("---------------------------");
Console.WriteLine(usuarioPorId.ToString());

