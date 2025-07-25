using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Teacher : User
    {
        public string Department {  get; set; }

        public Teacher() { }
        public Teacher(int id, string name, string email, string department)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Department = department;
        }

        public void TeacherInfo()
        {
            Console.WriteLine($"{Id} {Name} {Email} {Department}");
        }
    }
}
