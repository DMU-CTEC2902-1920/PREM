using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookProject.Models
{
    public class Book
    {
        public virtual int BookId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual string Author { get; set; }
        public virtual string Title { get; set; }
        public virtual string Publisher { get; set; }
       
        public virtual Genre Genre { get; set; }

    }
}