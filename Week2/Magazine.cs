using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    internal class Magazine : LibraryItem
    {
        public int IssueNumber;
        public string Frequency;

        public Magazine(string title, string author, int publicationYear, int issueNumber, string frequency) : base(title, author, publicationYear)
        {
            IssueNumber = issueNumber;
            Frequency = frequency;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"IssueNumber and Frequency: {IssueNumber}, {Frequency}");
        }
    }
}
