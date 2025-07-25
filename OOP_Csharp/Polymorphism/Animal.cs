using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Animal
    {
        public void Movement_1()
        {
            Console.WriteLine("Sleep");
        }

        // Function Overload. Accessed to Function Override.
        public virtual void Movement_1(string genre)
        {
            Console.WriteLine(genre + " : " + "No Movement");
        }
    }
}
