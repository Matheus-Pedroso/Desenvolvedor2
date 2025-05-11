namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            Dictionary<string, double> faturamentoEstados = new Dictionary<string, double>
            {
                {"SP", 67836.43},
                {"RJ", 36678.66},
                {"MG", 29229.88},
                {"ES", 27165.48},
                {"Outros", 19849.53}
            };

            foreach (var valor in faturamentoEstados.Values) 
                total += valor;

            Console.WriteLine("-------------------");
            Console.WriteLine("Faturamento Total por Estado:");

            foreach (var estado in faturamentoEstados)
                Console.WriteLine($"Estado: {estado.Key} - Percentual: {(estado.Value / total) * 100:F2}%");
        }
    }
}
