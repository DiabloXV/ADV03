namespace ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
        {
            new Book("123", "C# Programming", new string[] { "John Doe" }, DateTime.Now, 29.99m),
            new Book("456", "Java Programming", new string[] { "Jane Doe" }, DateTime.Now.AddYears(-1), 39.99m)
        };

            // Using User-Defined Delegate
            LibraryEngine.ProcessBooks(books, Book.GetTitle);

            // Using Built-In Func Delegate
            LibraryEngine.ProcessBooks(books, Book.GetAuthors);

            // Using Anonymous Method
            LibraryEngine.ProcessBooks(books, delegate (Book B)
            {
                return B.ISBN;
            });

            // Using Lambda Expression
            LibraryEngine.ProcessBooks(books, B => B.PublicationDate.ToShortDateString());
        }
    }
}
