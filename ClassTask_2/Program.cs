using System;

namespace ClassTask_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = "asd$#@gkasd@$al;o**vczsd@)#((((=@soihj$";

            Parser parser = new Parser(@string);

            string[] parsedstring  = parser.StringParsing();

            for (int i = 1; i < parsedstring.Length; i++)
            {
                Console.WriteLine($"{i}. {parsedstring[i]}");

                Console.WriteLine("New String for Git");
            }

            Console.ReadLine();
        }
    }
}
