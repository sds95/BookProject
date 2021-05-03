using System;

namespace BookApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название - ");
            string title = Console.ReadLine();
            Console.WriteLine("Введите имя автора - ");
            string author = Console.ReadLine();
            Console.WriteLine("Введите содержание - ");
            string content = Console.ReadLine();

            Book book = new Book(title, author, content);

            Console.ReadKey();
        }
    }
}
