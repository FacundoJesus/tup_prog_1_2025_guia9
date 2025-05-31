namespace Ejercicio2
{
    internal class Program
    {
        static bool DeterminarSiEsPrimoYMeLoDevuelva(int n, out int numeroPrimo)
        {
            numeroPrimo = 0;
            bool siEsPrimo;
            int divisores = 0;
            for (int j = 1;  j <= n; j++) {
                if (n % j == 0)
                {
                    divisores++;
                }
            }

            if (divisores == 2)
            {
                numeroPrimo = n;
                siEsPrimo = true;
            }
            else
            {
                siEsPrimo =  false;
            }
            return siEsPrimo;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- NUMEROS PRIMOS ---");
            Console.WriteLine("Ingrese un Rango Inicial para obtener los Números Primos:");
            int inicio = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Ingrese un Rango Final para obtener los Números Primos:");
            int final = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n--- NUMEROS PRIMOS entre {inicio} y {final} ---");
            for (int i = inicio; i <= final; i++) {
                if (DeterminarSiEsPrimoYMeLoDevuelva(i, out int numeroPrimo))
                {
                    Console.Write($"{numeroPrimo,-3}");
                }
            }

        }
    }
}
