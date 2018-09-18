using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = -5; var num =  3;

            target = -num; // Noncompliant; target = -3. Is that really what's meant?
            target = +num; // Noncompliant; target = 3
        }
    }
}
