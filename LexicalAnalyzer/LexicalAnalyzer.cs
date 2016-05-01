using System;
using System.Collections.Generic;

namespace Compiler
{   
    public class LexicalAnalyzer
    {
        System.IO.StreamReader _file;
        List<Tuple<string, string, bool>> symbolList;
        public LexicalAnalyzer(System.IO.StreamReader file)
        {
            _file = file;
        }

        public static void compareKeyword(string builtString)
        {
            if (builtString.Equals("int"))
            {
                Console.WriteLine("keyword: int");
            }
            else if (builtString.Equals("void"))
            {
                Console.WriteLine("keyword: void");
            }
            else if (builtString.Equals("char"))
            {
                Console.WriteLine("keyword: char");
            }
            else if (builtString.Equals("else"))
            {
                Console.WriteLine("keyword: else");
            }
            else if (builtString.Equals("if"))
            {
                Console.WriteLine("keyword: if");
            }
            else if (builtString.Equals("while"))
            {
                Console.WriteLine("keyword: while");
            }
            else if (builtString.Equals("return"))
            {
                Console.WriteLine("keyword: return");
            }
            else
            {
                if (!(builtString.Equals("")))
                {
                    float lexNumber = 0.0f;
                    bool checkFloat = float.TryParse(builtString, out lexNumber);
                    if (checkFloat)
                        Console.WriteLine("number: " + lexNumber);
                    else
                        Console.WriteLine("id: " + builtString);
                }
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
                            compareKeyword(building);
                            Console.WriteLine(";");
                            building = "";
                            break;
                        case ',':
                            compareKeyword(building);
                            Console.WriteLine(",");
                            building = "";
                            break;
                        case '!':
                            compareKeyword(building);
                            Console.WriteLine("!");
                            building = "";
                            break;
                        case '=':
                            compareKeyword(building);
                            Console.WriteLine("=");
                            building = "";
                            break;
                        case '+':
                            compareKeyword(building);
                            Console.WriteLine("+");
                            building = "";
                            break;
                        case '-':
                            compareKeyword(building);
                            Console.WriteLine("-");
                            building = "";
                            break;
                        case '/':
                            compareKeyword(building);
                            Console.WriteLine("/");
                            building = "";
                            break;
                        case '*':
                            compareKeyword(building);
                            Console.WriteLine("*");
                            building = "";
                            break;
                        case '>':
                            compareKeyword(building);
                            Console.WriteLine(">");
                            building = "";
                            break;
                        case '<':
                            compareKeyword(building);
                            Console.WriteLine("<");
                            building = "";
                            break;
                        case '{':
                            compareKeyword(building);
                            Console.WriteLine("{");
                            building = "";
                            break;
                        case '}':
                            compareKeyword(building);
                            Console.WriteLine("}");
                            building = "";
                            break;
                        case ')':
                            compareKeyword(building);
                            Console.WriteLine(")");
                            building = "";
                            break;
                        case '(':
                            compareKeyword(building);
                            Console.WriteLine("(");
                            building = "";
                            break;
                        case '[':
                            compareKeyword(building);
                            Console.WriteLine("[");
                            building = "";
                            break;
                        case ']':
                            compareKeyword(building);
                            Console.WriteLine("]");
                            building = "";
                            break;
                        case ' ':
                            compareKeyword(building);
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