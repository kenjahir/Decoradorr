class Program
{
    static void main(string[] args)
    {
        var RegularOrden = new OrdenRegular();
        Console.Writeline(RegularOrden.CalcularTotalPrecioOrden());
        Console.Writeline();

        var preOrden = new PreOrden();
        Console.Writeline(preOrden.CalcularTotalPrecioOrden());
        Console.Writeline();

        var ordenPremium = new OrdenPremium();
        Console.Writeline(ordenPremium.CalcularTotalPrecioOrden());
        Console.Writeline();
    }
}