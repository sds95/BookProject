using System;

namespace BookApplication
{
    class Book
    {
        private string title;
        private string author;
        private string content;
        
        public void Create()
        {
            Title title = new Title();
            title.AddTitle = this.title;
            
            Author author = new Author();
            author.AddAuthor = this.author;

            Content content = new Content();
            content.AddContent = this.content;

            ShowBook(title, author, content);
        }

        public void ShowBook(Title title, Author author, Content content)
        {
            title.Show();
            author.Show();
            content.Show();
        }

        public Book(string title, string author, string content)
        {
            this.title = title;
            this.author = author;
            this.content = content;          
        }
    }
}
