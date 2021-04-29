using System;

namespace BookApplication
{
    class Book
    {
        private string title;
        private string author;
        private string content;
        
        public void AddBook()
        {
            Title title = new Title();
            title.AddTitle = this.title;
            Console.WriteLine("Название - ");
            title.Show();

            Author author = new Author();
            author.AddAuthor = this.author;
            Console.WriteLine("Автор - ");
            author.Show();

            Content content = new Content();
            content.AddContent = this.content;
            Console.WriteLine("Содержание - ");
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
