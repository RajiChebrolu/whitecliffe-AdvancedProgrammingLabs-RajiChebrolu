using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int Pages;

        public void Read() {
            Console.WriteLine("---------Book Details--------");
            Console.WriteLine("Title:" + Title);
            Console.WriteLine("Author:" + Author);
            Console.WriteLine("Pages" + Pages);
            Console.WriteLine("Book is being read");
        }
    }
}
