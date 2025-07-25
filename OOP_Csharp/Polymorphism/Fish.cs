using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Fish : Animal
    {
        // Function Override.
        public override void Movement_1(string genre)
        {
            Console.WriteLine(genre + " : " + "Swim");
        }
    }
}
