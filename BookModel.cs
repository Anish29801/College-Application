using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Application
{
    public class BookModel
    {
        // Book Model
        private int bookId = 0;
        private string tittle = string.Empty;
        private string author = string.Empty;
        private double price = 0.0;


        // Book Properties

        public int BookId
        {
            get { return bookId; }
            set
            {
                bookId = value;
            }
        }
        public string BookTittle
        {
            get { return tittle; }
            set
            {
                tittle = value;
            }
        }
        public string Author
        {
            get { return author; }
            set
            {
                author = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
    }
}
