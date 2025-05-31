namespace Ejercicio3
{
    internal class Program
    {
        static int Factorial(int numero)
        {
           int valor;
           switch (numero) {
                case 0:
                case 1:
                    valor = 1;
                    break;
                default:
                    valor = numero * Factorial(numero - 1);
                    break;
           }
            return valor;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número para obtener el Factorial:");
            int nFactorial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"El factorial de {nFactorial} es {Factorial(nFactorial)}.");
        }
    }
}
