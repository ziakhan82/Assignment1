using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
  public  class Book
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public int PageNumber { get; set; }
        public String ISBN13 { get; set; }

        public Book()
        {

        }

        public Book(String title,String author,int pagenumber,String isbn13)
        {
            this.Title = title;
            this.Author = author;
            this.PageNumber = pagenumber;
            this.ISBN13 = isbn13;
        }
    }
}
