using System;
using System.IO;

namespace BookSerializer {
    class MainClass {
        static string dbFile = "data.txt";

        public static void Main(string[] args) {
            BookList books;
            if (File.Exists(dbFile)) {
                try {
                    books = SerializedReaderWriter.Read<BookList>(dbFile);

                    Console.WriteLine("Read " + books.Count + " books from file");

                    foreach (var book in books) {
                        Console.WriteLine(book.Author);
                        Console.WriteLine(book.Title);
                    }
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            } else {
                books = new BookList {
                    new Book { Author = "Douglas Adams", Title = "The Hitch Hiker's Guide to the Galaxy"},
                    new Book { Author = "Douglas Adams", Title = "Dirk Gently's Holistic Detective Agency"}
                };

                // TODO: Handle exceptions!
                SerializedReaderWriter.Write<BookList>(dbFile, books);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
