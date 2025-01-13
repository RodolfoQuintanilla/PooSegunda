class Gerente : Empleado
{
    public double Bono { get; set; }

    public Gerente(string nombre, string apellido, int id, double salriobase, double bono) : base(nombre, apellido, id, salriobase)
    {
        Bono = bono;
    }

    public override void CalcularSalario()
    {
        Console.WriteLine($"Hola {Nombre} {Apellido} el salrio base es: {SalarioBase} tu bono es: {Bono} y teda un total {SalarioBase + Bono}");
    }
}