using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookProject.Models
{
    public class Book
    {
        public virtual int ISBN { get; set; }
        public virtual int GenreId{ get; set; }
        public virtual string Author { get; set; }
        public virtual string Title { get; set; }
        public virtual string Publisher { get; set; }
        public virtual DateTime YearPublished { get; set; }
        public virtual int ShelfNumber { get; set; }
        public virtual int EditionNumber { get; set; }
        public virtual string GenreName { get; set; }




    }
}