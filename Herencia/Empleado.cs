class Empleado
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int ID { get; set; }
    public double SalarioBase { get; set; }

    public Empleado(string nombre, string apellido, int id, double salario)
    {
        Nombre = nombre;
        Apellido = apellido;
        ID = id;
        SalarioBase = salario;
    }

    public virtual void CalcularSalario()
    {
        Console.WriteLine($"Hola {Nombre} el salrio base es: {SalarioBase}");
    }
}
