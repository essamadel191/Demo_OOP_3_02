using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_OOP_3_02
{
    internal class Library
    {
        public string Name { get; set; }

        private List<Books> _books = new List<Books>();

        public int BooksCount => _books.Count;

        public Library(string name)
        {
            Name = name;
        }

        public void AddBook(Books book)
        {
            _books.Add(book);
        }

        // Indexer 
        // Search By ISBN
        // Get Book By position

        public Books this[int index]
        {

            get
            {
                if(index < 0 || index >= _books.Count)
                {
                    Console.WriteLine("Index is out of range.");
                    return null;
                }
                return _books[index];
            }
            set
            {
                if (index < 0 || index >= _books.Count)
                {
                    Console.WriteLine("Index is out of range.");
                    return;
                }
                _books[index] = value;
            }
        }

        // Indexer Overloading
        public Books this[string isbn]
        {
            get
            {
                foreach (var book in _books)
                {
                    if (book.ISBN == isbn)
                    {
                        return book;
                    }
                }
                Console.WriteLine("Book not found.");
                return null;
            }
        }


    }
}
