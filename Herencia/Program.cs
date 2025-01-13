class Program
{
    static void Main(string[] args)
    {
        Empleado empleado = new Empleado("Luis", "Perez", 5040, 1500);
        empleado.CalcularSalario();

        Gerente gerente = new Gerente("Juan", "Ortiz", 5879, 5300, 700);
        gerente.CalcularSalario();

        Vendedor vendedor = new Vendedor("Felipe", "Martinez", 5689, 2000, 200);
        vendedor.CalcularSalario();
    }
}