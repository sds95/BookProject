using System;

namespace BookApplication
{
    class Book
    {
        public Book(string _title, string _author, string _content)
        {
            Title title = new Title { AddTitle = _title };
            Author author = new Author { AddAuthor = _author };
            Content content = new Content { AddContent = _content };

            ShowBook(title, author, content);
        }
        public static void ShowBook(Title title, Author author, Content content)
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
