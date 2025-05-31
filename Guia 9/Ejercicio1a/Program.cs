namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de términos para calcular la Seria de Fibonacci:");
            int terminos = Convert.ToInt32(Console.ReadLine());

            int valorActual = 0;
            int valorAnterior = 0;

            for (int i = 0; i < terminos; i++) {
                if (i == 0 || i == 1) {
                    valorActual = i;
                    valorAnterior = 0;
                }
                else
                {
                    int proximoValor = valorActual + valorAnterior;
                    valorAnterior = valorActual;
                    valorActual = proximoValor;
                }
                Console.Write($"{valorActual,-3}");
            }
        }
    }
}
