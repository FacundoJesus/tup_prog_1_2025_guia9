namespace Ejercicio1b
{
    internal class Program
    {
        static int CalcularTerminoFibonacci(int termino)
        {
            switch(termino)
            {
                case 0:
                case 1:
                    return termino;                 
                default:
                    int valor = CalcularTerminoFibonacci(termino - 1) + CalcularTerminoFibonacci(termino - 2); 
                    return valor;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de términos para calcular la Seria de Fibonacci:");
            int terminos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < terminos; i++) {
                int valor = CalcularTerminoFibonacci(i);
                Console.WriteLine(valor);
            }
        }
    }
}
