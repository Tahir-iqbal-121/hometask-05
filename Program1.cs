using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_9_march
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "oops";
            book1.Author = "AQBILAL";
            book1.Genre = "CS Book";
            book1.Publicationyear = 1990;

            Book book2 = new Book();
            book2.title = "maths";
            book2.Author = "ijaaz ali";
            book2.Genre = "textile book";
            book2.Publicationyear = 1999;

            Library library_obj= new Library();
             
            library_obj.addbooks(book1);
            library_obj.addbooks(book2);

            library_obj.listallbooks();

            string sech = "AQBILAL";
            library_obj.searchbook(sech);

            Console.ReadLine();
        }
    }
}
