using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace Store_Book_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isShopping = true;
            List <Book> Books = new List <Book>();

            while (isShopping)
            {
                Book Book_Choised = new Book();

                Console.WriteLine("Welcome to Store book , Please add the name and price of the book purchased ");
                Book_Choised.Nom = Console.ReadLine();

                Console.WriteLine("Enter the price ");
                Book_Choised.Price = Convert.ToDouble(Console.ReadLine());

                Books.Add(Book_Choised);

                Console.WriteLine("Do you Want to Remove a book !!");
                var BookToRemove = Console.ReadLine(); // Yes or No .

                if (BookToRemove == "yes")
                {
                    Console.WriteLine("enter the name of the book you want to remove ");
                    var Book_Removed = Console.ReadLine();

                    Book ActualBook = new Book();

                    foreach (var ToRemoved in Books)
                    {
                        if (ToRemoved.Nom.Contains(Book_Removed))
                            ActualBook = ToRemoved;

                        else
                            Console.WriteLine("Looks their is no Book with this Name ");
                    }
                    Books.Remove(ActualBook);
                }

                Console.WriteLine("Do you want to Keep Shopping ");
                var Respond_User = Console.ReadLine(); // Yes or No 

                if (Respond_User == "no")
                {
                    var total = 0.00;
                    isShopping = false;

                    foreach (var book in Books)
                    {
                        Console.WriteLine($"Your Book : \t \n {book.Nom}");
                        total += book.Price;
                    }
                    Console.WriteLine($"Your Total is {total}\n");
                }
            }
            
        }
    }
}
