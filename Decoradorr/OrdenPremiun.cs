class OrdenPremium: Decorador
{
    public OrdenPremium (OrdenBase orden): base(orden) { }

    public override double CalcularTotalPrecioOrden()
{
    Console,Writeline($"Calculo del precio total en la clase {name of(OrdenPremium)}.");
    var preOredenprecio = base.CalcularTotalPrecioOrden();
    Console,Writeline("Adicion de un descuento adicional al precio anticipado");
    return preOredenprecio * 0.9;
}
         
}