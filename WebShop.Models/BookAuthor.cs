using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Models
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        public int AuthorID { get; set; }

        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
