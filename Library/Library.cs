using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        public List<Book> books = new List<Book>();
        public List<Guest> guests = new List<Guest>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void CheckoutBook(Guest guest)
        {
            guests.Add(guest);
        }

        public void DisplayBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
