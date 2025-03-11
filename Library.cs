using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_9_march
{
    internal class Library
    {
        private Book[] books;
        public int bookcount;

        public Library()
        {
            books=new Book[100];
            bookcount=0;
        }

        public void addbooks(Book book1)
        {
            books[bookcount] = book1;
            bookcount++;
            Console.WriteLine("book successfully added ");
        }
        public void listallbooks()
        {
            Console.WriteLine("all books available in library ");
            for (int i = 0; i < bookcount; i++)
            {
               Console.WriteLine("title is "+books[i].title);
                Console.WriteLine("author is " + books[i].Author);
                Console.WriteLine("genre is " + books[i].Genre);
                Console.WriteLine("publication year  is " + books[i].Publicationyear);
            }
        }
        public void searchbook(string keyword)
        {
            Console.WriteLine($"search value for keyword={keyword}");
            for (int i = 0; i < bookcount; i++) 
            {
                if (books[i].title == keyword || books[i].Author == keyword || books[i].Genre == keyword)
                {
                    Console.WriteLine("title is " + books[i].title);
                    Console.WriteLine("author is " + books[i].Author);
                    Console.WriteLine("genre is " + books[i].Genre);
                    Console.WriteLine("publication year  is " + books[i].Publicationyear);
                    break;
                }
            
            }
            }
    }
}
