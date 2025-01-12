/* public class Caja<X>
{
static void Main()
{
int x = 5, y = 10;
Console.WriteLine($"Antes del intercambio: x = {x}, y = {y}");
}    private X contenido;

    public void Guardar(X elemento)
    {
        contenido = elemento;
    }

    public X Obtener()
    {
        return contenido;
    }
} */



using System;

class Program
{
    // Método genérico para intercambiar dos valores
    public static void Intercambiar<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        // Prueba con enteros
        int x = 5, y = 10;
        Console.WriteLine($"Antes del intercambio: x = {x}, y = {y}");
        Intercambiar(ref x, ref y);
        Console.WriteLine($"Después del intercambio: x = {x}, y = {y}");

        // Prueba con cadenas
        string str1 = "Hola", str2 = "Mundo";
        Console.WriteLine($"\nAntes del intercambio: str1 = {str1}, str2 = {str2}");
        Intercambiar(ref str1, ref str2);
        Console.WriteLine($"Después del intercambio: str1 = {str1}, str2 = {str2}");

        // Prueba con booleanos
        bool b1 = true, b2 = false;
        Console.WriteLine($"\nAntes del intercambio: b1 = {b1}, b2 = {b2}");
        Intercambiar(ref b1, ref b2);
        Console.WriteLine($"Después del intercambio: b1 = {b1}, b2 = {b2}");
    }
}


