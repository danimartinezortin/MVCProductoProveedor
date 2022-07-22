namespace MVCProductoProveedor.Models.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; }

        public Producto()
        {
        }

        public Producto(string nombre, int precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}
