class Decorador : OrdenBase
{
    protected OrdenBase orden;
    public Decorador(OrdenBase orden)
    {
        this.orden = orden;
    }
    public override double CalcularTotalPrecioOrden()
    {
        Console.Writeline("Calculo del precio total desde la clase decorador");
        return orden.CalcularTotalPrecioOrden().
    }
}