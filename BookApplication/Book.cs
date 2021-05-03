using System;

namespace BookApplication
{
    class Book
    {
        private Title _title;
        private Author _author;
        private Content _content;

        public Book(string title, string author, string content)
        {
            _title = new Title { AddTitle = title };
            _author = new Author { AddAuthor = author };
            _content = new Content { AddContent = content };
        }

        public void ShowBook()
        {
            this._title.Show();
            this._author.Show();
            this._content.Show();
        }
    }
}
