using Task.Models;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book book = new Book() 
            //{
            //    Name = "Test",
            //    AuthorName = "Test",
            //    PageCount = 1,
            //    Price = 1,
            //};
            //Book book1 = new Book()
            //{
            //    Name = "Test1",
            //    AuthorName = "Test1",
            //    PageCount = 2,
            //    Price = 3,
            //};
       
            Library library = new Library();
            library.AddBook("test", "test", 14, 14.3);
            library.AddBook("test", "test", 113, 14.3);
            library.AddBook("test2", "test2", 47, 124.9);
            library.AddBook("test3", "test3", 10, 17.8);
            //library.GetBook("Test");
            //library.GetBook("Test2");
            //library.GetBook("Test3");
            List<Book> books= library.FindAllBooks("test");
            foreach (Book book in books) 
            {
                Console.WriteLine(book.AuthorName);
            }
            int howtime = library.FindAllBooks("test").Count();
            Console.WriteLine("How many remove book :"+howtime);
       
        }
    }
}
