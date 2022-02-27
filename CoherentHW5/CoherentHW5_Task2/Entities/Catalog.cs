using System.Text;
using System.Text.RegularExpressions;

namespace CoherentHW5_Task2.Entities
{
    internal class Catalog
    {
        private readonly Dictionary<string, Book?> _books;
        private readonly string _name;
        public Catalog(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                _name = name;
                _books = new Dictionary<string, Book?>();
            }
            else
            {
                throw new ArgumentException("Catalog name is empty");
            }
        }
        public void AddNewBook(string isbn, Book? book)
        {
            if (Regex.IsMatch(isbn, "^[0-9]{3}-[0-9]{1}-[0-9]{2}-[0-9]{6}-[0-9]{1}$"))
            {
                _books.Add(isbn, book);
            }
            else
            {
                throw new ArgumentException("Wrong format isbn");
            }
        }

        public Book? GetBookByIsbn(string isbn)
        {
            Book? book;

            if (Regex.IsMatch(isbn, "^[0-9]{3}-[0-9]{1}-[0-9]{2}-[0-9]{6}-[0-9]{1}$"))
            {
                _books.TryGetValue(isbn, out book);
                return book;
            }
            else if (Regex.IsMatch(isbn, "^[0-9]{13}$"))
            {
                var formattedIsbn = Regex.Replace(isbn, @"^(.{3})(.{1})(.{2})(.{6})(.{1})$", "$1-$2-$3-$4-$5");
                _books.TryGetValue(formattedIsbn, out book);
                return book;
            }
            else
            {
                throw new ArgumentException("Incorrect isbn");
            }
        }

        public override string ToString()
        {
            StringBuilder outPutCatalogElements = new ($"Name of the books in {_name} catalog:\n");

            foreach (var element in _books)
            {
                outPutCatalogElements.Append(element + "\n");
            }

            return outPutCatalogElements.ToString();
        }
    }
}
