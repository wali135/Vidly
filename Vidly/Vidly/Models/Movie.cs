﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Genre { get; set; }   
        
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Added Date")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        public int Stock { get; set; }

        


    }

    //Movie/random
}