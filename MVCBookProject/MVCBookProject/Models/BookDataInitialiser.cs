using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCBookProject.Models
{
    public class BookDataInitialiser: DropCreateDatabaseAlways<BookContext>
    {

        protected override void Seed(BookContext context)
        {
            Genre gen1 = new Genre();
            gen1.GenreId = 1;
            gen1.Name = "Drama";
            gen1.Description = "Hurt";
            context.Genres.Add(gen1);
            Genre gen2 = new Genre();
            gen2.GenreId = 2;
            gen2.Name = "Romance";
            gen2.Description = "Love";
            context.Genres.Add(gen2);
            Book bk1 = new Book();
            bk1.BookId = 1;
            bk1.GenreId = 1;
            bk1.Author = "musical";
            bk1.Publisher = "More terrible hits";
            bk1.Title = "gfhf";
            bk1.Genre = gen1;
            context.Books.Add(bk1);
            Book bk2 = new Book();
            bk2.BookId = 2;
            bk2.GenreId = 2;
            bk2.Author = "Rom-Com";
            bk2.Title = "Loving";
            bk2.Publisher = "More terrible hits";
            bk2.Genre = gen2;
            context.Books.Add(bk2);
            base.Seed(context);
        }
    }
}