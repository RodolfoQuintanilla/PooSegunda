class Motor
{
    public void Encender() => Console.WriteLine("Motor encendido.");
}

class Automovil
{
    private Motor motor;

    // El Automóvil recibe un motor ya existente como parámetro.
    public Automovil(Motor motor)
    {
        this.motor = motor;
    }

    public void EncenderAutomovil()
    {
        motor.Encender();
        Console.WriteLine("Automóvil encendido.");
    }
}

class Program
{
    static void Main()
    {
        Motor motor = new Motor(); // Se crea un motor independiente.
        Automovil auto = new Automovil(motor); // El automóvil utiliza el motor.

        auto.EncenderAutomovil();
    }
}