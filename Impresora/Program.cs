/* 3. Clases Abstractas y Métodos Abstractos

Ejercicio:

Piensa en un sistema para dibujar diferentes formas geométricas. 

Define una clase abstracta llamada Forma que contenga:

-Un método abstracto llamado CalcularArea().
-Un método concreto llamado DibujarContorno() que imprime un mensaje genérico indicando que se está dibujando el contorno de una forma.
Luego, describe cómo crearías clases derivadas como Cuadrado y Círculo que hereden de Forma e implementen el método abstracto CalcularArea().

Puntos a considerar para tu respuesta:

Declaración de la clase abstracta Forma y sus miembros.
Implementación del método CalcularArea() en las clases Cuadrado y Círculo (¿qué fórmulas usarían?).
Explicar por qué la clase Forma debe ser abstracta.
¿Se podría instanciar directamente un objeto de la clase Forma? ¿Por qué?


formula circulo A = pi *r2
Formula cuadeado Lado * lado
 */


public abstract class Forma
{
    public abstract int CalcularArea();

    public void DibujarContorno()
    {
        Console.WriteLine($"Se está dibujando el contorno de una forma.");
    }
}

class Cuadrado : Forma
{
    public int Base { get; set; }
    public int Altura { get; set; }


    public Cuadrado(int bases, int altura)
    {
        Base = bases;
        Altura = altura;
    }
    public override int CalcularArea()
    {
        return Base * Altura;
    }
}

public class Circulo : Forma // Ejemplo con otra forma
{
    public double Radio { get; set; }

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override int CalcularArea()
    {
        return (int)(Math.PI * Radio * Radio); // Casteo a int porque CalcularArea devuelve int
    }
}


class Program
{
    public static void Main(string[] args)
    {
        Cuadrado cuadrado = new Cuadrado(5, 7);
        int areaCuadrado = cuadrado.CalcularArea();
        cuadrado.DibujarContorno();
        Console.WriteLine($"El área del cuadrado es: {areaCuadrado}");


      /*   Circulo circulo = new Circulo(3);
        int areaCirculo = circulo.CalcularArea();
        circulo.DibujarContorno();
        Console.WriteLine($"El área del círculo es: {areaCirculo}"); */


        Forma forma1 = new Cuadrado(4, 4); // Un cuadrado ES una forma
        Forma forma2 = new Circulo(2.5); // Un círculo ES una forma

        Console.WriteLine($"Área de forma1: {forma1.CalcularArea()}"); // Llama a la implementación de Cuadrado
        Console.WriteLine($"Área de forma2: {forma2.CalcularArea()}"); // Llama a la implementación de Círculo
    }


}