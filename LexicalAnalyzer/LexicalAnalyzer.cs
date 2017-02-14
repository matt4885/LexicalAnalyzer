using System;
using System.Collections.Generic;

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
                        var lexNumber = 0.0f;
                        var checkFloat = float.TryParse(builtString, out lexNumber);
                        if (checkFloat)
                            Console.WriteLine("number: " + lexNumber);
                        else
                            Console.WriteLine("id: " + builtString);
                    }
                    break;
            }

        }//compareKeyword
  
        public void performLex()
        {
            string line;
            string building = "";
            while ((line = _file.ReadLine()) != null)
            {
                if (!(line.Equals("")))
                    Console.WriteLine("INPUT: " + line);
                for (int i = 0; i < line.Length; i++)
                {
                    switch (line[i])
                    {
                        case ';':
                            CompareKeyword(building);
                            Console.WriteLine(";");
                            building = "";
                            break;
                        case ',':
                            CompareKeyword(building);
                            Console.WriteLine(",");
                            building = "";
                            break;
                        case '!':
                            CompareKeyword(building);
                            Console.WriteLine("!");
                            building = "";
                            break;
                        case '=':
                            CompareKeyword(building);
                            Console.WriteLine("=");
                            building = "";
                            break;
                        case '+':
                            CompareKeyword(building);
                            Console.WriteLine("+");
                            building = "";
                            break;
                        case '-':
                            CompareKeyword(building);
                            Console.WriteLine("-");
                            building = "";
                            break;
                        case '/':
                            CompareKeyword(building);
                            Console.WriteLine("/");
                            building = "";
                            break;
                        case '*':
                            CompareKeyword(building);
                            Console.WriteLine("*");
                            building = "";
                            break;
                        case '>':
                            CompareKeyword(building);
                            Console.WriteLine(">");
                            building = "";
                            break;
                        case '<':
                            CompareKeyword(building);
                            Console.WriteLine("<");
                            building = "";
                            break;
                        case '{':
                            CompareKeyword(building);
                            Console.WriteLine("{");
                            building = "";
                            break;
                        case '}':
                            CompareKeyword(building);
                            Console.WriteLine("}");
                            building = "";
                            break;
                        case ')':
                            CompareKeyword(building);
                            Console.WriteLine(")");
                            building = "";
                            break;
                        case '(':
                            CompareKeyword(building);
                            Console.WriteLine("(");
                            building = "";
                            break;
                        case '[':
                            CompareKeyword(building);
                            Console.WriteLine("[");
                            building = "";
                            break;
                        case ']':
                            CompareKeyword(building);
                            Console.WriteLine("]");
                            building = "";
                            break;
                        case ' ':
                            CompareKeyword(building);
                            building = "";
                            break;
                        default:
                            building += line[i].ToString();
                            break;
                    } //switch
                }//for
            }//while
        }//performLex()
    }//LexicalAnalyzer
}//namespace