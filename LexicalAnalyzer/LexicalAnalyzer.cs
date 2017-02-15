using System;

namespace LexicalAnalyzer
{   
    public class LexicalAnalyzer
    {
        private readonly System.IO.StreamReader _file;
        public LexicalAnalyzer(System.IO.StreamReader file)
        {
            _file = file;
        }

        public static void CompareKeyword(string builtString)
        {
            switch (builtString)
            {
                case "int":
                case "void":
                case "char":
                case "else":
                case "if":
                case "while":
                case "return":
                    Console.WriteLine($"keyword: {builtString}");
                    break;
                default:
                    if (!(builtString.Equals("")))
                    {
                        float lexNumber;
                        var checkFloat = float.TryParse(builtString, out lexNumber);
                        Console.WriteLine(checkFloat ? $"number: {lexNumber}" : $"id: {builtString}");
                    }
                    break;
            }

        }//compareKeyword
  
        public void PerformLex()
        {
            string line;
            var building = "";
            while ((line = _file.ReadLine()) != null)
            {
                if (!(line.Equals("")))
                    Console.WriteLine("INPUT: " + line);
                foreach (var t in line)
                {
                    if (!char.IsLetter(t) && t != ' ')
                    {
                        CompareKeyword(building);
                        Console.WriteLine(t);
                        building = string.Empty;
                    }
                    else
                    {
                        building += t.ToString();
                    }
                }
            }//while
        }//performLex()
    }//LexicalAnalyzer
}//namespace