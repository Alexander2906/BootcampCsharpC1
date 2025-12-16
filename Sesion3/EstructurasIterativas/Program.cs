// See https://aka.ms/new-console-template for more information
int opcion = 0;


while (opcion!= 7)
{
    Console.WriteLine("Ingrese numero a operar");
    double numero1 = double.Parse(Console.ReadLine());
    double numero2 = double.Parse(Console.ReadLine());
    double resultado = 0;
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

    switch(opcion)
    {
        case 1:
            resultado = numero1 + numero2;
            Console.WriteLine("Resultado: " + resultado);
            break;
        case 2:
            resultado = numero1 - numero2;
            Console.WriteLine("Resultado: " + resultado);
            break;
        case 3:
            resultado = numero1 * numero2;
            Console.WriteLine("Resultado: " + resultado);
            break;
        case 4:
            if (numero2 != 0)
            {
                resultado = numero1 / numero2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else
            {
                Console.WriteLine("Error: Division por cero");
            }
            break;
        case 5:
            resultado = Math.Pow(numero1, numero2);
            Console.WriteLine("Resultado: " + resultado);
            break;
        case 6:
            if (numero1 >= 0)
            {
                resultado = Math.Sqrt(numero1);
                Console.WriteLine("Resultado: " + resultado);
            }
            else
            {
                Console.WriteLine("Error: Raiz cuadrada de un numero negativo");
            }
            break;
        case 7:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opcion invalida. Intente de nuevo.");
            break;
    }
}
Console.WriteLine("Fin del programa");
