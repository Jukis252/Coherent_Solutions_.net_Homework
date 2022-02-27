using System.Text;

namespace CoherentHW5_Task2.Entities
{
    internal class Book
    {
        private string Title { get; set; }
        private DateTime? DateOfPublication { get; set; }
        private HashSet<string>? Authors { get; set; }

        public Book(string title)
        {
            if (!String.IsNullOrEmpty(title))
            {
                Title = title;
            }
            else
            {
                throw new ArgumentException("Book title is empty");
            }

        }

        public Book(string title, DateTime? dateOfPublication) : this(title)
        {
            DateOfPublication = dateOfPublication;
        }

        public Book(string title, DateTime? dateOfPublication, HashSet<string>? authors) : this(title, dateOfPublication)
        {
            Authors = authors;
        }
        public override string ToString()
        {
            StringBuilder sb = new ($"Book title: {Title}\n" +  $"Date of publication: {DateOfPublication}\n" + $"Authors: ");

            if (Authors != null)
            {
                foreach (var author in Authors)
                {
                    sb.Append(author + "\n");
                }
            }
            return sb.ToString();
        }
    }
}
