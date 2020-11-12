using System;


namespace Open_Lab_10._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book("The Return of the King", 416, "Fantasy", "J.R.R. Tolkien", 2003);
            Book LOTR2 = new Book();
            Book LOTR3 = new Book("The Fellowship of the Ring", 0);
            Book HOBIT = new Book("Hobbit", 423, "Fantasy", "J.R.R. Tolkien", 1954);
            LOTR.PrintBookInfo();

            LOTR2.PrintBookInfo();

            LOTR3.PrintBookInfo();

            HOBIT.PrintBookInfo();

            Console.ReadKey();
        }
    }
    class Book
    {
        private string empty = ", ";

        private int pages;

        private string title;

        private string category;

        private string author;

        private int releaseDate;
        public Book(string ttl, int pgs, string ctgr, string athr, int dt)
        {
            title = ttl;
            pages = pgs;
            category = ctgr;
            author = athr;
            releaseDate = dt;
        }

        public Book()
        {
            title = "-1";

            pages = -1;

            category = "-1";

            author = "-1";

            releaseDate = -1;
        }
        public Book(string ttl, int pgs)
        {
            title = ttl;

            pages = pgs;

            category = "-1";

            author = "-1";

            releaseDate = -1;
        }

        public void SetTitle(string ttl)
        {
            title = ttl;
        }
        public void SetPages(int pgs)
        {
            if (pgs >= 0)
                pages = pgs;
            else
                pages = 1;

        }
        public void SetCategory(string ctgr)
        {
            category = ctgr;
        }
        public void SetAuthor(string athr)
        {
            author = athr;
        }
        public void SetReleaseDate(int dt)
        {
            if (dt < 1450 || dt > 2021)
                releaseDate = -1;

            else
                releaseDate = dt;
        }
        public void PrintBookInfo()
        {
            Console.WriteLine(author + empty + title + empty + pages + empty + category + empty + releaseDate);
        }
    }
}