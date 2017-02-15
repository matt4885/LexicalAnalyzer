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

        /// <summary>
        /// Begins the lexical analyzer by adding symbols to a built string
        /// and then comparing them againstkeywords if we reach a delimiting character
        /// </summary>
        public void PerformLex()
        {
            string line;
            var building = "";
            while ((line = _file.ReadLine()) != null)
            {
                //Print only strings with content
                if (!(line.Equals("")))
                    Console.WriteLine("INPUT: " + line);

                //Comment handliing goes here

                foreach (var t in line)
                {
                    if (!(char.IsLetter(t) || char.IsWhiteSpace(t)))
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