﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }
        
        [Display (Name="Genre")]
        [Required]
        public byte GenreId { get; set; }
        public DateTime? DateAdded { get; set; }
        [Display (Name="Released date")]
        public DateTime ReleasedDate { get; set; }
        [Display (Name="Number in stock")]
        [Range(1,20)]
        public int NumberInStock { get; set; }
        public int NumberAvailable { get; set; }
    }
}