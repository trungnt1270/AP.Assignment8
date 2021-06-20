using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Novel:Book
    {
        public Book[] books;
        public Novel(int n)
        {
            books = new Book[n];
        }
        public Book this[int index]
        {
            get
            {
                if (index < 0 || index > books.Length)
                {
                    return null;
                }
                else
                {
                    return books[index];
                }
            }
            set
            {
                if (index >= 0 && index < books.Length)
                {
                    books[index] = value;
                }
            }
        }
        public  void display(Book[] books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.id}\t{book.name}\t\t{book.isbn}");
            }
         }
        }
    }
