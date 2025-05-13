using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Book : LibraryItem
    {
        private string ISBN;
        private string Genre;

        public Book(string title, string author, int publicationYear, string iSBN, string genre)
            : base(title, author, publicationYear)
        {
            ISBN = iSBN;
            Genre = genre;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"ISBN and Genre: {ISBN}, {Genre}");
        }
    }
}
