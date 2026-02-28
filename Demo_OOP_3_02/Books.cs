using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_OOP_3_02
{
    internal class Books
    {
        public string ISBN { get; set; }
        public string Title { get; set; }

        public Books(string isbn, string title)
        {
            ISBN = isbn;
            Title = title;
        }

        public override string ToString() => $"{ISBN} >> {Title}";
        


    }
}
