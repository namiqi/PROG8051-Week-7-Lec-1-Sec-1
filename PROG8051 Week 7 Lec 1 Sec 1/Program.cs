
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Book
    {
        // Fields
        string title;
        string author;
        string isbn;
        bool isAvailable = true;


        // Properties
        public string Title { get { return title; } }
        public string Author { get { return author; } }
        public string Isbn { get { return isbn; } }
        public bool IsAvailable { get { return isAvailable; } set { isAvailable = value; } }


        // Construct
        public Book(string btitle, string bauthor, string bisbn)
        {
            title = btitle;
            author = bauthor;
            isbn = bisbn;
        }

    }


    class Library
    {
        Book[] books = new Book[10];
        int count = 0;

        public void AddBook(Book book)
        {
            books[count++] = book;
            ListAvailableBooks();

        }

        public void RemoveBook(string isbn)
        {
            

            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if(books[i].Isbn == isbn)
                {
                    index = i;
                    
                }
            }

            books[index] = null;
            for(int i = index; i < count-1; i++)
            {
                books[i] = books[i + 1];
            }
            count--;
            Console.WriteLine("--------");
            ListAvailableBooks();
            

        }

        public void CheckOutBook(string isbn)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].Isbn == isbn && books[i].IsAvailable)
                {
                    books[i].IsAvailable = false;
                    Console.WriteLine($" Checked out: Title: {books[i].Title}, Author: {books[i].Author}");
                    return;
                }


            }
        }

        public void returnBook(string isbn)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].Isbn == isbn && !books[i].IsAvailable)
                {
                    books[i].IsAvailable = true;
                    Console.WriteLine($" Book returned: Title: {books[i].Title}, Author: {books[i].Author}");
                    return;
                }


            }
        }

        public void ListAllBooks()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Title: {books[i].Title}, Author: {books[i].Author}");
            }
        }

        public void ListAvailableBooks()
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].IsAvailable)
                {
                    Console.WriteLine($"Title: {books[i].Title}, Author: {books[i].Author}");
                }

            }
        }



    }



    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("1984", "George Orwell", "eqwqe1we5w4");
            Book book2 = new Book("Essentiliasim", "Martin", "eqwsdaqe1we5w4");
            Book book3 = new Book("SAT MAth", "Namiq", "qwerty");

            Library Robarts = new Library();
            Robarts.AddBook(book1);
            Robarts.AddBook(book2);
            Robarts.AddBook(book3);
            Robarts.ListAllBooks();

            Robarts.CheckOutBook("eqwsdaqe1we5w4");
            Robarts.ListAvailableBooks();
            Robarts.returnBook("eqwsdaqe1we5w4");
            Robarts.ListAvailableBooks();
            Robarts.RemoveBook("eqwsdaqe1we5w4");
            Robarts.AddBook(book2);

        }

    }

    /* class Test
     {
       private string nameofTest = "SAT";

       // Properties
       public string NameofTest
         {
             get { return nameofTest; }
             set { nameofTest = value; }
         }
     }

     class Car
     {

         // Class members

         // Fields / parameters
         int tires = 4;
         int doors = 4;
         bool windshield = true;
         int enginesize;
         int numofseat;

         // Methods
         public void Honk()
         {
             Console.WriteLine("Honk Honk");
         }

         // Constructor

         public Car(int carEngineSize, int CarNumofSeats)
         {
             enginesize = carEngineSize;
             numofseat = CarNumofSeats;  

         }

         // Access modifiers
         // public and private

         // How to create a class
         static void Main(string[] args)
         {
             Test sat = new Test();
             Console.WriteLine(sat.NameofTest);
             sat.NameofTest = "GMAT";
             Console.WriteLine(sat.NameofTest);


             // Classname objectname = new CLassName();

             // Object of Car class
             Car lexus = new Car(3500,4);
             Car bmw = new Car(4500, 2);



             Console.WriteLine(lexus.doors);
             Console.WriteLine(lexus.enginesize);
             Console.WriteLine(bmw.doors);
             Console.WriteLine(bmw.enginesize);


             Console.WriteLine(bmw.windshield);

             bmw.Honk();
         }
     }*/
}