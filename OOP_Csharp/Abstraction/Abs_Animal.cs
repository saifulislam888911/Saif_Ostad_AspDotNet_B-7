using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Abs_Animal
    {
        // Abstract Method : without body
        public abstract void Abs_Sound(); 

        // Regular Method
        public void Sleep() 
        {
            Console.WriteLine("Zzz..");
        }
    }
}
