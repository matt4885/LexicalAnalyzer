using System;
using System.IO;

namespace LexicalAnalyzer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                using (var file = new StreamReader(args[0]))
                {
                    var lex = new LexicalAnalyzer(file);
                    lex.PerformLex();
                }

            } catch (FileNotFoundException ex)
            {
                Console.WriteLine("Could not open file for reading. Check that the file exists and is in the source directory.");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
