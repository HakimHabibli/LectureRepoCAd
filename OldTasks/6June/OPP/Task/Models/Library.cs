using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
  

    internal class Book
    {
        private int _id;
        public Book()
        {
            _id = Id;
            _id++;
        }
        public  int Id {get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
        [NotMapped]
        public string Code => $"{this.Name}{this.Id}";

        
    }
    class Library
    {
        public List<Book> Books = new List<Book>();

        public void AddBook(string name,string authorName,int pageCount,double price) 
        {
            Book book = new Book() 
            {
                Name = name,
                AuthorName = authorName,
                PageCount = pageCount,
                Price = price
            };
            Books.Add(book);
        }
        public void GetBook(string name) 
        {
            Book book = Books.Find(x => x.Name == name);
            Console.WriteLine(book.Name);
        }
        public List<Book> FindAllBooks(string authorName) 
        {
            List<Book> result = null;
            result = Books.FindAll(x => x.AuthorName == authorName);
            return result;
        }
        public int RemoveAllBooks(List<Book> books,string authorName)
        {
            return books.RemoveAll(x => x.AuthorName == authorName);
        }

    }
    internal class Order()
    {
        public int Id { get; set; }
        public List<Book> Books { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }

        

    }
}
