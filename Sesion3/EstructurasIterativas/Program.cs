// See https://aka.ms/new-console-template for more information
int opcion = 0;


while (opcion!= 7)
{
    Console.WriteLine("Calculadora:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Potencia");
    Console.WriteLine("6. Raiz");
    Console.WriteLine("7. Salir");
    Console.WriteLine("Seleccione una opcion (1-7):");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.WriteLine("Sumando");
    }
    if (opcion == 2)
        {
        Console.WriteLine("Restando");
    }
}
Console.WriteLine("Fin del programa");
