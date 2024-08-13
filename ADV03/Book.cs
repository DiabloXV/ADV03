using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV03
{
    public class Book
    {
        // Properties
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }



        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        // Method to get the Authors of the book
        public static string GetAuthors(Book B)
        {
            return string.Join(", ", B.Authors);
        }

        // Method to get the Price of the book
        public static string GetPrice(Book B)
        {
            return B.Price.ToString("C");
        }
    }
}
