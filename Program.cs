using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdtool
{
    class Program
    {
        static void Main(string[] args)
        {
            
            String str = Console.ReadLine();
            Console.WriteLine(DateTime.Now.ToString() + " Hello : " + str);
            Console.ReadKey();

        }
    }
}
