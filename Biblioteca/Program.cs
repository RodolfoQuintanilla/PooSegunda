/* class Cpu
{
    public string Modelo { get; set; }

    public void MostrarInformacion() => Console.WriteLine($"Computadora encendida.");
}

class Computadora
{
    private Cpu cpu;
    public Computadora()
    {
        cpu = new Cpu();
    }

    public void EncenderPC()
    {
        cpu.MostrarInformacion();
        Console.WriteLine("CPU: Intel Core i7");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Computadora computadora = new Computadora();
        computadora.EncenderPC();
    }
} */

//Agregacion

class Cpu
{
    public string Modelo { get; set; }

    public void MostrarInformacion() => Console.WriteLine($"Computadora encendida.");
}

class Computadora
{
    public Cpu cpu;

    public Computadora(Cpu cpu)
    {
        this.cpu = cpu;
    }

    public void EncenderPC()
    {
        cpu.MostrarInformacion();
        Console.WriteLine("CPU: Intel Core i7");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cpu cpu = new Cpu();
        Computadora computadora = new Computadora(cpu);
        computadora.EncenderPC();
    }
}
