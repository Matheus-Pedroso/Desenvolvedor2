namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var palavra = Console.ReadLine();

            if (palavra == null)
            {
                Console.WriteLine("A palavra não pode ser nula.");
                return;
            }

            var resultado = "";

            for (int i = palavra.Length -1; i >= 0; i--)
                resultado += palavra[i];

            Console.WriteLine($"A palavra invertida é: {resultado}");
        }
    }
}
