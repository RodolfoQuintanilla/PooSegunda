/* Propiedades:

X (tipo double)
Y (tipo double)
Z (tipo double)
Métodos:

Un constructor que reciba los valores de X, Y, y Z.
Sobrecargar el operador + para sumar dos objetos de tipo Punto3D.
Sobrecargar el operador - para restar dos objetos de tipo Punto3D.
Sobrecargar el operador == para comparar si dos puntos son iguales.
Sobrecargar el operador != para comparar si dos puntos son diferentes.
Otros:

Redefinir el método ToString para mostrar un punto en el formato: (X, Y, Z).
 */



public class Punto3D
{
    public double X;
    public double Y;
    public double Z;

    public Punto3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Punto3D operator +(Punto3D p1, Punto3D p2)
    {
        return new Punto3D(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
    }

    public override string ToString()
    {
        return $"({X},{Y},{Z})";
    }

}

class Program
{
    static void Main(string[] args)
    {
        Punto3D p1 = new Punto3D(3.5, 2.0, 3.6);
        Punto3D p2 = new Punto3D(1.5, 4.0, 4.5);
        Punto3D p3 = new Punto3D(5.5, 9.8, 8.2);

        // Sumar los vectores usando el operador sobrecargado
        Punto3D resultado = p1 + p2 + p3;

        Console.WriteLine($"Vector 1: {p1}");
        Console.WriteLine($"Vector 2: {p2}");
        Console.WriteLine($"Vector 3: {p3}");
        Console.WriteLine($"Resultado de la suma: {resultado}");
    }
}