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
            string text;
            text = Console.ReadLine();
            string letter = "@";
            int count = text.Where(a => a.ToString() == letter).ToList().Count();
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
