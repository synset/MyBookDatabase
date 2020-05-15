using System;
using System.Collections.Generic;

namespace MyBookDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            bool running = true;

            do
            { 
            Console.WriteLine("Main menu\n" +
                "1. Add book, enter 1\n" +
                "2. Display all books, enter 2\n" +
                "3. Search for book, enter 3\n" +
                "4. Delete book, enter 4\n" +
                "0. Exit program, enter 0");

            string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "0":
                        running = false;
                        break;

                    case "1":
                        Console.WriteLine("\nEnter title: ");
                        string title = Console.ReadLine();

                        Console.WriteLine("\nEnter name of the author: ");
                        string author = Console.ReadLine();

                        Book book = new Book(title, author);
                        books.Add(book);

                        Console.WriteLine("\nThe book: '" + book.Title + "' by " + book.Author + " is now registered in our Book Database.");

                        break;


                    case "2":

                        if (books.Count == 0)
                        {
                            Console.WriteLine("\nThere are no books in My Book Database.");
                        }
                        else
                        {
                            Console.WriteLine("\nBooks in the Database: ");

                            foreach (Book myBook in books)
                            {
                                Console.WriteLine("\nTitle: " + myBook.Title + " Author: " + myBook.Author + "\n");
                            }
                        }
                        break;


                    case "3":
                        Console.WriteLine("\nEnter the title for the book you are searching for: ");

                        string bookTitle = Console.ReadLine();

                        if (books.Count == 0)
                        {
                            Console.WriteLine("\nThere are no books in My Book Database.\n");
                        }
                        else
                        
                            foreach (Book myBook in books)
                            {
                                if (bookTitle == myBook.Title)
                                    Console.WriteLine("\n" + myBook.Title + " by " + myBook.Author + "\n");
                                else
                                    Console.WriteLine("\nThe book: '" + myBook.Title + "' is not found in My Book Database.");
                            }
                        break;

                    case "4":
                        Console.WriteLine("\nAt what position is the book you want to delete?: ");

                        int position = int.Parse(Console.ReadLine());

                        if (books.Count >= position)
                        {

                            books.RemoveAt(position);
                            Console.WriteLine("The book at position " + position + "is now deleted from My Book Database");
                        }
                        else
                        {
                            Console.WriteLine("There is no position " + position);
                        }

                        break;

                    default:
                        Console.WriteLine(
                            "\nInvalid choice\n" +
                            "Choose a alternative from the Main menu\n");
                        break;
                
            }//end switch

            } while (running);
        }//end main

        public class Book
        {
            public string Title;
            public string Author;
            public Book(string title, string author)
            {
                Title = title;
                Author = author;
            }
        }

    }//end class Program
}//end namespace
