using System;
using System.IO;

namespace Compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var file = new StreamReader(args[0]))
                {
                    LexicalAnalyzer.LexicalAnalyzer lex = new LexicalAnalyzer.LexicalAnalyzer(file);
                    lex.PerformLex();
                }

            } catch (FileNotFoundException ex)
            {
                Console.WriteLine("Could not open file for reading. Check that the file exists and is in the source directory.");
                Console.WriteLine(ex.Message);
                Console.ReadLine();              
            }
            
        }
    }
}
