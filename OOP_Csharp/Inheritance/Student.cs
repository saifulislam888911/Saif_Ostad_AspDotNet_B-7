using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Student : User
    {
        public int Mark {  get; set; }

        public Student() { }
        public Student(int id, int mark) 
        { 
            this.Id = id;
            this.Mark = mark;
        }

        public void StudentMark()
        {
            Console.WriteLine($"{Id} {Mark}");
        }
    }
}
