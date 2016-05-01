using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader file = new StreamReader(args[0]))
                {
                    LexicalAnalyzer lex = new LexicalAnalyzer(file);
                    lex.performLex();
                    Console.ReadLine();
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
