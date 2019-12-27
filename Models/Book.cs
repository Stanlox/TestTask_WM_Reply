using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WM_Reply.Models
{
    public class Book
    {
        public string Name { get; set; }

        public string shortDesc { get; set; }
        public string longDesc { get; set; }

        public string img { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryID { get; set; }

    }
}