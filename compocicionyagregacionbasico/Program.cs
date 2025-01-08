//Composición 
class Motor
{
    public void Encender() => Console.WriteLine("Motor encendido");
}
class Automovil
{
    private Motor motor; //??????
    public Automovil()
    {
        motor = new Motor(); // Composición: El automóvil crea su motor.
    }

    public void EncenderAutomovil()
    {
        motor.Encender();
        Console.WriteLine("Automovil encendido");
    }
}

/* class Program
{
    static void Main(string[] args)
    {
      //  Automovil automovil = new Automovil();
      //  automovil.EncenderAutomovil();
    }
} */