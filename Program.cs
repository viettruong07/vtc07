using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title = "Developer";
            book.Author = "Cong Viet";
            book.PublicationYear = 2021;
            Console.WriteLine(book.ToString());


            Magazine magazine = new Magazine();
            magazine.Title = "Gia Dinh Minh bat thinh Linh";
            magazine.Author = "VTV2";
            magazine.PublicationYear = 2023;
            Console.WriteLine(magazine.ToString());

            DVD dvd = new DVD();
            dvd.Title = "Kho qua bo qua?";
            dvd.Author = "VTC";
            dvd.PublicationYear = 2020;
            Console.WriteLine(dvd.ToString());


            Console.ReadLine();
        }
    }