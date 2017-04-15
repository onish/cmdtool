using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmdtool
{
    static class Helper
    {
        public static void WriteLine(String Message)
        {
            Console.WriteLine(DateTime.Now.ToString() + " Log Entry : " + Message);
        }
    }
}
