using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some text");
            string text = Console.ReadLine();
            string letter = "@";
            int counter;
            int result = 0;

            
            foreach (char c in text)
            {
                counter = text.Where(a => a.ToString() == letter).ToList().Count();
                if (letter == "@")
                {
                    counter++;
                    if (letter == "@")
                    {
                        result++;
                        counter = 0;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
                
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
