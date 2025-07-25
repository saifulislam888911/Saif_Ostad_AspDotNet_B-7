using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_in_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object : Book class's new object has been created and arguments values have been passed to the constructor.
            Book book = new Book("Deyal", "Humayun Ahmed", 195);
            book.DisplayInfo();
            book.BorrowBook();
            book.DisplayInfo();
            book.ReturnBook();
            book.DisplayInfo();
        }
    }
}
