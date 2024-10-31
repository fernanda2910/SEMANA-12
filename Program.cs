using ConsoleApp13;
using System.Runtime.InteropServices;

byte opcion;
String regresar;
Estudiantes e = new Estudiantes();
do
{
    Console.WriteLine("BIENVENIDOS AL SITIO DE REGISTRO DE EDADES");
    Console.WriteLine("******** MENU *********");
    Console.WriteLine("     1. INSERTAR     ");
    Console.WriteLine("     2. MOSTRAR     ");
    Console.WriteLine("     3. ELIMINAR     ");
    Console.WriteLine("     4. ORDENAR     ");
    Console.WriteLine("     0. SALIR     ");
    Console.WriteLine("***********************");
    Console.Write("INGRESE OPCION: ");
    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 4)
    {
        Console.WriteLine("ERROR: INGRESE OPCION: ");
    }
    switch (opcion)
    {
        case 0: Environment.Exit(0); break;
        case 1: e.insertar(); break;
        case 2: e.mostrar(); break;
        case 3:
            Console.Write("\nINGRESE EDAD A ELIMINAR: ");
            byte ed = byte.Parse(Console.ReadLine());
            e.eliminar(ed);
            break;
        case 4: break;
    }
    Console.WriteLine("\n\nDESEA REGRESAR AL MENU? [SI]");
    regresar = Console.ReadLine().ToUpper();
    Console.Clear();
} while (regresar == "SI");