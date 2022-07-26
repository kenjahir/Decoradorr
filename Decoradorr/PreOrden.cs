public class PreOrden : OrdenBase
{
    public override double CalcularTotalPrecioOrden()
    {
        Console.Writeline("Calculo del precio total de un pedido anticipado");
        return products.Sum(x => x.Precio) * 0.9;
    }

}

