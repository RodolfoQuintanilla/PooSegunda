


class Fracciones
{
    public int Numerador { get; set; }
    public int Denominador { get; set; }

    public Fracciones(int numerador, int denominador)
    {
        if (denominador == 0)
        {
            throw new ArgumentException("El denominador no puede ser cero.");
        }

        Numerador = numerador;
        Denominador = denominador;
    }


    public static Fracciones operator +(Fracciones f1, Fracciones f2)
    {
        int nuevoDenominador = f1.Denominador * f2.Denominador;
        int nuevoNumerador = (f1.Numerador * f2.Denominador) + (f2.Numerador * f1.Denominador);

        return new Fracciones(nuevoNumerador, nuevoDenominador);
    }

    public static Fracciones operator -(Fracciones f1, Fracciones f2)
    {
        int nuevoDenominador = f1.Denominador * f2.Denominador;
        int nuevoNumerador = (f1.Numerador * f2.Denominador) - (f2.Numerador * f1.Denominador);

        return new Fracciones(nuevoNumerador, nuevoDenominador);
    }

    public static Fracciones operator *(Fracciones f1, Fracciones f2)
    {
        int nuevoNumerador = f1.Numerador * f2.Numerador;
        int nuevoDenominador = f1.Denominador * f2.Denominador;
        return new Fracciones(nuevoNumerador, nuevoDenominador);

    }

    public static Fracciones operator /(Fracciones f1, Fracciones f2)
    {
         if (f2.Numerador == 0)
        {
            throw new DivideByZeroException("No se puede dividir por una fracción con numerador cero.");
        }

        int nuevoNumerador = f1.Numerador * f2.Denominador;
        int nuevoDenominador = f1.Denominador * f2.Numerador;

        return new Fracciones(nuevoNumerador, nuevoDenominador);
    }



    public override string ToString()
    {
        return $"{Numerador}/{Denominador}";
    }

}

class Program
{
    static void Main(string[] args)
    {
        Fracciones f1 = new Fracciones(1, 2);
        Fracciones f2 = new Fracciones(3, 4);

        Fracciones suma = f1 + f2;
        Fracciones resta = f1 - f2;
        Fracciones muntiplicacion = f1 * f2;
        Fracciones division = f1 / f2;

        Console.WriteLine($"fraccion 1 {f1} ");
        Console.WriteLine($"fraccion 2 {f2} ");
        Console.WriteLine($"Resultado de la suma fraccion {suma} ");
        Console.WriteLine($"Resultado de la resta fraccion {resta} ");
        Console.WriteLine($"Resultado de la muntiplicacion fraccion {muntiplicacion} ");
        Console.WriteLine($"Resultado de la divicion fraccion {division} ");
    }
}