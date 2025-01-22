interface IMantenimiento
{
    void MostrarDetalles();
    void Arrancar();
    void RealizarMantenimiento();
}


class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public Vehiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Ano}");
    }

    public virtual void Arrancar()
    {
        Console.WriteLine($"El vehiculo {Modelo} se ha arrancado");
    }

    public static Vehiculo operator +(Vehiculo a1, Vehiculo a2)
    {
        if (a1 == null || a2 == null)
            throw new ArgumentException("Uno o ambos vehículos son nulos.");

        string nuevaMarca = $"{a1.Marca} & {a2.Marca}";
        string nuevoModelo = $"{a1.Modelo} & {a2.Modelo}";

        // Elegir el año más reciente como ejemplo
        int nuevoAno = Math.Max(a1.Ano, a2.Ano);

        // Crear y retornar un nuevo Vehiculo
        return new Vehiculo(nuevaMarca, nuevoModelo, nuevoAno);
    }

}

class Auto : Vehiculo, IMantenimiento
{
    public int CantidadDePuertas { get; set; }

    public Auto(string marca, string modelo, int ano, int puertas) : base(marca, modelo, ano)
    {
        CantidadDePuertas = puertas;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Ano}, CantidadDePuertas: {CantidadDePuertas}");
    }
    public override void Arrancar()
    {
        Console.WriteLine($"El vehiculo {Modelo} se ha arrancado");
    }

    public void RealizarMantenimiento()
    {
        Console.WriteLine($"El auto {Modelo} se ha realizado el mantenimiento en los primero 1,000 kilometros");
    }
}

class Camion : Vehiculo, IMantenimiento
{
    public int CapacidadDeCarga { get; set; }

    public Camion(string marca, string modelo, int ano, int carga) : base(marca, modelo, ano)
    {
        CapacidadDeCarga = carga;
    }
    public override void MostrarDetalles()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Ano}, Capacidad de Carga: {CapacidadDeCarga}");
    }
    public override void Arrancar()
    {
        Console.WriteLine($"El vehiculo {Modelo} se ha arrancado");
    }
    public void RealizarMantenimiento()
    {
        Console.WriteLine($"El camion {Modelo} se ha realizado el mantenimiento en los primero 500 kilometros");
    }
}

class Moto : Vehiculo, IMantenimiento
{
    public bool EsDeportiva { get; set; }

    public Moto(string marca, string modelo, int ano, bool deportiva) : base(marca, modelo, ano)
    {
        EsDeportiva = deportiva;
    }


    public override void MostrarDetalles()
    {
        if (EsDeportiva)
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Ano} si es deportiva");
        }
        else
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Ano} no es Deportiva ");
        }
    }

    public override void Arrancar()
    {
        Console.WriteLine($"El vehiculo {Modelo} se ha arrancado");
    }

    public void RealizarMantenimiento()
    {
        Console.WriteLine($"El vehiculo {Modelo} se ha realizado el mantenimiento el primer mes");
    }
}


public static class CalculadoraCombustible
{
    public static decimal Combustible { get; private set; }
    public static decimal Calculo(decimal distancia, decimal consumoPorKm, decimal precioPorLitro)
    {

        if (distancia <= 0)
            throw new ArgumentException("La distancia debe ser mayor a 0.");
        if (consumoPorKm <= 0)
            throw new ArgumentException("El consumoPorKm debe ser mayor a 0");
        if (precioPorLitro <= 0)
            throw new ArgumentException("El precioPorLitro debe ser mayor a 0");

        return Combustible = (distancia / consumoPorKm) * precioPorLitro;

    }
}


class Program
{
    static void Main(string[] args)
    {
        IMantenimiento autoMantenimiento = new Auto("Toyota", "Cambri", 2024, 4);
        Auto auto = (Auto)autoMantenimiento;
        auto.MostrarDetalles();
        auto.Arrancar();
        auto.RealizarMantenimiento();

        decimal distancia = 150;
        decimal consumoPorKm = 15;
        decimal precioPorLitro = 2.5m;

        decimal costoCombustible = CalculadoraCombustible.Calculo(distancia, consumoPorKm, precioPorLitro);
        Console.WriteLine($"El costo del combustible para {distancia} km es: {costoCombustible}.");
        Console.WriteLine(" ");

        IMantenimiento mantenimientoMoto = new Moto("Italica", "Mortal", 2025, false);
        Moto moto = (Moto)mantenimientoMoto;
        moto.MostrarDetalles();
        moto.Arrancar();
        moto.RealizarMantenimiento();


        decimal distancia1 = 1000;
        decimal consumoPorKm1 = 5;
        decimal precioPorLitro1 = 2.5m;

        decimal costoCombustible1 = CalculadoraCombustible.Calculo(distancia1, consumoPorKm1, precioPorLitro1);
        Console.WriteLine($"El costo del combustible para {distancia1} km es : {costoCombustible1}");
        Console.WriteLine(" ");

        IMantenimiento camionMantenimiento = new Camion("Mercedes Benz", "Micro", 2020, 1);
        Camion camion = (Camion)camionMantenimiento;
        camion.MostrarDetalles();
        camion.Arrancar();
        camion.RealizarMantenimiento();

        decimal distancia2 = 500;
        decimal consumoPorKm2 = 55;
        decimal precioPorLitro2 = 2.5m;

        decimal costoCombustible2 = CalculadoraCombustible.Calculo(distancia2, consumoPorKm2, precioPorLitro2);
        Console.WriteLine($"El costo del combustible para {distancia2} km es: {costoCombustible2}");


        Vehiculo vehiculo1 = new Vehiculo("Toyota", "Corolla", 2020);
        Vehiculo vehiculo2 = new Vehiculo("Honda", "Civic", 2022);

        // Usar el operador sobrecargado
        Vehiculo vehiculoCombinado = vehiculo1 + vehiculo2;

        // Mostrar detalles del nuevo vehículo
        vehiculoCombinado.MostrarDetalles();
    }
}