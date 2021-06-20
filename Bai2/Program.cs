using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Novel novels = new Novel(5);

            novels[0] = new Book("1", "The american", "100-123-456");
            novels[1] = new Book("3", "The Chinee", "100-123-678");
            novels[2] = new Book("1", "The american", "100-123-456");
            novels[3] = new Book("4", "The Italian", "100-123-89643");
            novels[4] = new Book("5", "The Korean", "100-123-2135");
          
            Console.WriteLine("Category :NOVEL ");

            Console.WriteLine("Book ID \t BookName \t\t ISBN Number");
            Console.WriteLine("------- \t--------\t\t----------");


            novels.display(novels.books);


            Console.ReadKey();

        }

    }
}
