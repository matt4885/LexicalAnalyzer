using System;
using System.IO;
namespace LexicalAnalyzer
{   
    public class LexicalAnalyzer
    {
        #region Properties

        private readonly StreamReader _file;

        #endregion


        #region Constructor

        public LexicalAnalyzer(StreamReader file)
        {
            _file = file;
        }

        #endregion

        /// <summary>
        /// Compares token word to list of keywords. If it matches the keyword it prints that
        /// keyword. If it does not match, it checks if its a number or an id.
        /// </summary>
        /// <param name="builtString">Current token word being passed in</param>
        public static void CompareKeyword(string builtString)
        {
            switch (builtString)
            {
                case "char":
                case "int":
                case "void":
                case "float":
                case "else":
                case "if":
                case "while":
                case "return":
                    Console.WriteLine($"keyword: {builtString}");
                    break;
                default:
                    if (!builtString.Equals(""))
                    {
                        float lexNumber;
                        var checkFloat = float.TryParse(builtString, out lexNumber);
                        Console.WriteLine(checkFloat ? $"number: {lexNumber}" : $"id: {builtString}");
                    }
                    break;
            }

        }//end CompareKeyword

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
                    //If we reach a delimiting character compare against a keyword and write char to screen
                    if (!(char.IsLetter(t) || char.IsWhiteSpace(t) || char.IsNumber(t) || t == '.'))
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
            }
        }
    }
}