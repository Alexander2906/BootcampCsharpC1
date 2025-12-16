// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, Alumnos");
// variables
int edad = 20;
long altura = 180L;
double dinero = 1500.50;
float peso = 70.5f;
decimal saldo = 10000.75m;
String nombre = "pedro";
char letra = 'A';
bool tieneGorro = true;
Console.WriteLine("Escribe tu nombre:");
nombre = Console.ReadLine();
Console.WriteLine("Mi nombre es, " + nombre);
Console.WriteLine($"Mi altura es, {altura}");
Console.WriteLine("Ecribe tu dinero");
//Este es e comentario de prueba
/* 
    Comentario de bloque
 */

dinero = double.Parse(Console.ReadLine());
Console.WriteLine($"Tu dinero es, {dinero}");