using System;

namespace BookApplication
{
    class Content
    {
        private string content;

        public string AddContent
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.WriteLine("Содержание - " + content);
        }
    }
}
