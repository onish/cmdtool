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
            Helper.WriteLog(str);
            Console.ReadKey();

        }
    }
}
