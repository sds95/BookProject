using System;

namespace BookApplication
{
    class Title
    {
        private string title;

        public string AddTitle
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public void Show()
        {
            Console.WriteLine("Название - " + title);
        }
    }
}
