namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            bool pertence = false;

            if (!int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Número inválido. Por favor, insira um número inteiro");
                return;
            }

            while (a <= numero)
            {
                if (a == numero)
                {
                    pertence = true;
                    break;
                }

                int proximo = a + b;
                a = b;
                b = proximo;
            }

            if (pertence)
                Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            else
                Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }
}
