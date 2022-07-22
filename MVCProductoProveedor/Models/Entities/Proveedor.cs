namespace MVCProductoProveedor.Models.Entities
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string email { get; set; }

        public List<Producto> Productos { get; set; }

        public Proveedor()
        {
        }
        public Proveedor(string nombre, string dNI, string email)
        {
            Nombre = nombre;
            DNI = dNI;
            this.email = email;
        }
    }
}
