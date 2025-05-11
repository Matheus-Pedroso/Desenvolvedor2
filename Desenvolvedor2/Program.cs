namespace Desenvolvedor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int INDICE = 13;
            double soma = 0;
            int K = 0;

            while (K < INDICE)
            {
                K++;
                soma = soma + K;
            }
            Console.WriteLine(soma);
        }
    }
}
