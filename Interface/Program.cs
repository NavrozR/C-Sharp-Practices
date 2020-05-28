using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {


            InterfaceChild c = new InterfaceChild();
            c.Add();
            int x = c.Sub();
            Console.WriteLine(x);

        }
    }
}