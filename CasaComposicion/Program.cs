class Habitacion
{
    public string Tipo { get; set; }

    public Habitacion(string tipo)
    {
        Tipo = tipo;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"La habitación es de tipo {Tipo}");
    }
}

class Casa
{
    private Habitacion habitacion;

    public Casa(string nombreHabitacion)
    {
        habitacion = new Habitacion(nombreHabitacion);
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Habitacion es: {habitacion.Tipo}");
        habitacion.MostrarInformacion();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Casa casa = new Casa("Baño");
        Casa casa2 = new Casa("Recamara");
        casa.MostrarInfo();
        casa2.MostrarInfo();
    }
}