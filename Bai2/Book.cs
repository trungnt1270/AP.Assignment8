using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Book
    {
        public string id { get; }
        public string name { get;}
        public string isbn { get;}

      
        public Book() { }
        public Book(string id, string name, string isbn)
        {
            this.id = id;
            this.name = name;
            this.isbn = isbn;
        }


    }
}
