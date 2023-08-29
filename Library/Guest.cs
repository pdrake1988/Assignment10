using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Guest
    {
        public Guest(string name, int age, List<Book> books)
        {
            this.Name = name;
            this.Age = age;
            this.Books = books;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public List<Book> Books { get; set; }
    }
}
