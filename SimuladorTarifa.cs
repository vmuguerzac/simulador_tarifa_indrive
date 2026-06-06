public class SimuladorTarifa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===============================================");
        Console.WriteLine("         InDrive - Simulador de Tarifa");
        Console.WriteLine("===============================================");
        // Entrada de Datos
        Console.WriteLine("Nombre del Pasajero: ");
        string nombre = Console.ReadLine();
        
        Console.WriteLine("Ingrese distancia del viaje (KM): ");
        double distancia = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Hora de Salida (0 hrs - 23 hrs): ");
        int hora = int.Parse(Console.ReadLine());
        
        Console.WriteLine("\nTipo de Vehículo: ");
        Console.WriteLine(" 1. Economico");
        Console.WriteLine(" 2. Confort");
        Console.WriteLine(" 3. Premium");
        Console.WriteLine(" 4. Moto");
        Console.WriteLine("Ingrese la opcion: ");
        int tipoVehiculo = int.Parse(Console.ReadLine());
        // Proceso


        // Salida
    }
}