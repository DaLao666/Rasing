using BLOG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BLOG.Models
{
    public class Movie
    {   
        public int ID { get; set; }
        public string Tittle { get; set; }

        [Display(Name="Realesae Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}"),applyFormatInEditMode=true)]
        public DateTime RealeaseDate { get; set; }
        public string Genre{ get; set; }
        public decimal Price { get; set; }
    }

    internal class applyFormatInEditModeAttribute : Attribute
    {
    }

    public class MovieDBContext : DbContext {
        public DbSet<Movie> Movies { get; set; }


    }
}