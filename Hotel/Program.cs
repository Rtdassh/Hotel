using System.ComponentModel.Design;

do
{
    try
    {
        LecturaSwitch();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Sucedio algo terrible {0}", ex);
        Console.ReadKey();
    }
} while (true);

int Menu()
{
    Console.Clear();
    Console.WriteLine("Hotel Bella Vista");
    Console.WriteLine("1. Agregar Habitación");
    Console.WriteLine("2. Eliminar habitación");
    Console.WriteLine("3. Mostrar habitación");
    Console.WriteLine("4. Asignar habitación a cliente");
    Console.WriteLine("5. Liberar Habitación");
    Console.WriteLine("6. Salida");
    Console.Write("Ingrese una opcion: ");
    int option = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    return option;
}

void LecturaSwitch()
{
    switch (Menu())
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            Console.WriteLine("Ciao amigo!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("No se reconoció la opción :(");
            break;
    }
    Console.ReadKey();
}
