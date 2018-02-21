using System;
using System.Linq;

namespace SymbolCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            char findSymbol = 'A';

            Console.WriteLine("Введите строку:");
            string source = Console.ReadLine();

            int count = new Program().SymbolCount(findSymbol, source);

            Console.WriteLine($"Количество символов '{findSymbol}' = {count}");
            Console.ReadKey();
        }
        public int SymbolCount(char findSymbol, string source)
        {
            int count = source.Count(f => f == findSymbol);
            return count;
        }
    }
}
