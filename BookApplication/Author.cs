using System;

namespace BookApplication
{
    class Author
    {
        private string author;

        public string AddAuthor
        {
            get { return author; }
            set { author = value; }
        }

        public void Show()
        {
            Console.WriteLine("Автор - " + author);
        }
    }
}
