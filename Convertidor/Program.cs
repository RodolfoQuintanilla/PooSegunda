public static class Conversor
{
    private const double CELSIUS_A_FAHRENHEIT_FACTOR = 1.8;
    private const double CELSIUS_A_FAHRENHEIT_OFFSET = 32;
    private const double METROS_A_PIES = 3.2808;
    private const double PIES_A_METROS = 0.3048;
    public static double CelsiusAFahrenheit(double celsius)
    {
        if (celsius <= 0)
        {
            Console.WriteLine("Numero Incorrecto");
            return 0;
        }
        else
        {
            return (CELSIUS_A_FAHRENHEIT_FACTOR * celsius) + CELSIUS_A_FAHRENHEIT_OFFSET;
        }
    }

    public static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) / CELSIUS_A_FAHRENHEIT_FACTOR;
    }

    public static double MetrosAPies(double metros)
    {
        return metros * METROS_A_PIES;
    }
    public static double PiesAMetros(double pies)
    {
        return pies * PIES_A_METROS;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Conversor.CelsiusAFahrenheit(10));
        Console.WriteLine(Conversor.FahrenheitACelsius(50));
        Console.WriteLine(Conversor.MetrosAPies(10));
        Console.WriteLine(Conversor.PiesAMetros(10));

    }
}