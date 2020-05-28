using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class InterfaceChild : Interfaceexample
    {
        public void Add()

        {

            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        
        }

        public int Sub() 
        {
            int a = 10;
            int b = 5;
            int c = a - b;
            return c;
        
        
        }
    }
}
