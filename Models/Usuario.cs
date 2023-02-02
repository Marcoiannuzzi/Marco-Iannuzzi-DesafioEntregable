﻿namespace POO.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }

        public override string ToString()
        {
           return $"El usuario id:{this.Id} se llama {this.Nombre} {this.Apellido} y su nombre de usuario es: {this.NombreUsuario}";
        }
    }
}
