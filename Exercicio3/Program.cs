using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Exercicio3;

internal class Program
{
    static void Main(string[] args)
    {
        using (StreamReader r = new StreamReader("C:\\Users\\Administrator\\source\\repos\\Desenvolvedor2\\Exercicio3\\dados.json"))
        {
            string json = r.ReadToEnd();

            if (json == null)
            {
                Console.WriteLine("Erro ao ler o arquivo JSON.");
                return;
            }

            List<Faturamento> array = JsonSerializer.Deserialize<List<Faturamento>>(json);

            if (array == null)
            {
                Console.WriteLine("Erro ao desserializar o JSON.");
                return;
            }

            var diasComFaturamento = array.Where(d => d.valor > 0).ToList();
            var menorValor = diasComFaturamento.Min(d => d.valor);
            var maiorValor = diasComFaturamento.Max(d => d.valor);
            var mediaMensal = diasComFaturamento.Average(d => d.valor);
            var diasAcimaDaMedia = diasComFaturamento.Where(d => d.valor > mediaMensal).ToList();

            Console.WriteLine("Menor faturamento: {0:F2}", menorValor);
            Console.WriteLine("Maior faturamento: {0:F2}", maiorValor);
            Console.WriteLine("Dias com faturamento acima da média: {0}", diasAcimaDaMedia.Count);
        }
    }
}
