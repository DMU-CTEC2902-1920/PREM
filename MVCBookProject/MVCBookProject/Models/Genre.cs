﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBookProject.Models
{
    public class Genre
    {
        public virtual int GenreId { get; set; }
        public virtual string GenreName { get; set; }
        
    }
}