public abstract class OrdenBase
{
    protected List<Product> products = new List<Product>
    {
        new Product {Nombre = "Telefono", Precio = 300},
        new Product {Nombre = "Tablet", Precio = 800},
        new Product {Nombre = "PC GAMER ", Precio = 1800}
    };
    public abstract double CalcularTotalPrecioOrden();
}