using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace MvcPerpustakaan.Models
{
    public class BookGenreViewModel
    {
        public List<Book> Books;
        public SelectList Genres;
        public string BookGenre { get; set; }
        public string SearchString { get; set; }
    }
}