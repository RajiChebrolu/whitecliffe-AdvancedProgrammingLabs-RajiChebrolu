using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class LibraryItem
    {
        public string Title;
        public string Author;
        public int PublicationYear;

        public LibraryItem(string title,string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;            
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Library Book Details: {Title}, {Author}, {PublicationYear}");
        }
        
    }
}
