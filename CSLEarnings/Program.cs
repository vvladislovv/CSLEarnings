using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLEarnings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
           // ++i;
            Console.WriteLine((++i) + 2 + 1 + (i++) + "1"+ (++i)  * 2);
        }
    }
}
