﻿namespace POO.Models
{
    public class ProductoVendido
    {
        public long Id { get; set; }
        public long IdProducto { get; set; }
        public int Stock { get; set; }
        public long IdVenta { get; set; }
    }
}
