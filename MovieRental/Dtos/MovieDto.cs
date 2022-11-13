using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }
        public DateTime? DateAdded { get; set; }
       
        public DateTime ReleasedDate { get; set; }
        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
}