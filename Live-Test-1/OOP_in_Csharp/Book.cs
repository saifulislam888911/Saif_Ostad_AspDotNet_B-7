using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_in_Csharp
{
    internal class Book
    {
        // Encapsulation : Access Modifier used for codes visibility and accessing Properties & methods 
        public string Title {  get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public bool IsAvailable { get; set; }

        // Constructor : Parameterized Constructor has been used here.Arguments value sent to the parameters and properties values have been assigned here.
        public Book(string title, string author, int pages, bool isAvailable = true) 
        {
            this.Title = title;
            this.Author = author;
            this.Pages = pages;
            this.IsAvailable = isAvailable;
        }

        public void BorrowBook() 
        {
            IsAvailable = false;

            Console.WriteLine("Book has been borrowed.");
        }

        public void ReturnBook()
        {
            IsAvailable = true;

            Console.WriteLine("Book has been returned");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Pages: {Pages}, Available: {IsAvailable}");
        }
    }
}
