public abstract class ProductoElectronico
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public decimal Precio { get; set; }

    public ProductoElectronico(string marca, string modelo, decimal precio)
    {
        Marca = marca;
        Modelo = modelo;
        Precio = precio;
    }
    public abstract void MostrarEspecificaciones();

    public virtual void Encender()
    {
        Console.WriteLine($"El producto {Marca} - {Modelo}se ha encendido");
    }
}

public class Computadora : ProductoElectronico
{
    public string Procesador { get; set; }
    public int Ram { get; set; }

    public Computadora(string marca, string modelo, decimal precio, string procesador, int ram) : base(marca, modelo, precio)
    {
        Procesador = procesador;
        Ram = ram;
    }

    public override void MostrarEspecificaciones()
    {
        Console.WriteLine($"Computadora {Marca} {Modelo}");
        Console.WriteLine($"Procesador: {Procesador}");
        Console.WriteLine($"RAM: {Ram} GB");
    }
}


public class Telefono : ProductoElectronico
{
    public int MegapixelesCamara { get; set; }

    public Telefono(string marca, string modelo, decimal precio, int megapixelesCamara)
      : base(marca, modelo, precio)
    {
        MegapixelesCamara = megapixelesCamara;
    }

    public override void MostrarEspecificaciones()
    {
        Console.WriteLine($"Teléfono {Marca} {Modelo}");
        Console.WriteLine($"Cámara: {MegapixelesCamara} MP");
    }

    public override void Encender()
    {
        Console.WriteLine($"Iniciando teléfono {Marca} {Modelo}...");
    }
}

class Progra
{
    public static void Main(string[] args)
    {
        Computadora compu = new Computadora("Dell", "xdrs", 500, "i5", 16);
        compu.MostrarEspecificaciones();
        compu.Encender();

        Telefono tel = new Telefono("Appel", "Iphon", 700, 50);
        tel.MostrarEspecificaciones();
        tel.Encender();
    }
}