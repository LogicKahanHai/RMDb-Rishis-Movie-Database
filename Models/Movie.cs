using System;
using System.ComponentModel.DataAnnotations;

namespace RMDb.Models
{
	public class Movie
	{
        [Key]
        public int Id { get; set; }

        public required string Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal? Price { get; set; }

    }
}

