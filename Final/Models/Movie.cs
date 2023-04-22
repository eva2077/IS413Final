//This is model for the database. In this case there are two ways to do this. You can build model then migrate to build database.
//Or you could scaffold which is when you use the database to build the model.
//In this case we are doing both ways. We are going to have them work together at the same time.

using System;
using System.ComponentModel.DataAnnotations;
using Final.Models;
namespace Final.Models
{
	public class Movie
	{
        [Key]
        [Required]
        public int MovieId { get; set; } //If you want a read only just do get: ex like this: public string RecipeID { get; }
        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
	}
}

