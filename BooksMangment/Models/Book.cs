using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksMangment.Models
{
    public class Book
    {
        public int id { get; set; }
        public string auther { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }

    }
}