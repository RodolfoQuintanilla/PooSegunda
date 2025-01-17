/*
1. Crea una clase estática: Llámala Calculadora.
2. Define métodos estáticos: Dentro de esta clase, crea los siguientes métodos:
Sumar(int a, int b): Suma dos números enteros y devuelve el resultado.
Restar(int a, int b): Resta dos números enteros y devuelve el resultado.
Multiplicar(int a, int b): Multiplica dos números enteros y devuelve el resultado.
Dividir(int a, int b): 
Divide dos números enteros y devuelve el resultado. Implementa una comprobación para evitar divisiones por cero.
3. Define una constante: Crea una constante estática llamada PI con el valor de pi (3.14159).
4. Método para calcular el área de un círculo: Crea un método estático llamado CalcularAreaCirculo(double radio) que utilice la constante PI para calcular y devolver el área de un círculo dado su radio. */


public static class Calculadora
{

    public const double PI = 3.14159;

    public static int Suma(int a, int b)
    {
        return a + b;
    }
    public static int Resta(int a, int b)
    {
        return a - b;
    }
    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }
    public static int Dividir(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("No se puede dividir por cero");
        }
        else
        {
            return a / b;
        }
    }

    public static double CalculaAreaCirculo(double radio)
    {
        return PI * radio * radio;
    }
}

class Program{
    static void Main(string[] args){
        Console.WriteLine(Calculadora.Suma(5, 5));
        Console.WriteLine(Calculadora.Resta(10, 3));
        Console.WriteLine(Calculadora.Multiplicar(5, 5));
        Console.WriteLine(Calculadora.Dividir(10, 2));
        Console.WriteLine(Calculadora.CalculaAreaCirculo(5));
    }
}