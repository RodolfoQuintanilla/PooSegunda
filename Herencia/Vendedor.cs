class Vendedor : Empleado
{

    public int ComisionPorVenta { get; set; }

    public Vendedor(string nombre, string apellido, int id, double salriobase, int comision) : base(nombre, apellido, id, salriobase)
    {
        ComisionPorVenta = comision;
    }
    public override void CalcularSalario()
    {
        Console.WriteLine($"Hola {Nombre} {Apellido} el salrio base es: {SalarioBase} tu bono es: {ComisionPorVenta} y teda un total {SalarioBase + ComisionPorVenta}");
    }
}
