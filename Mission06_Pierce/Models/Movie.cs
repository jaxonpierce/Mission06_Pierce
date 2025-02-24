using System.ComponentModel.DataAnnotations;

namespace Mission06_Pierce.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public int Year { get; set; }

        public string Director { get; set; }

        public string Rating { get; set; }

        [Required]
        public bool Edited { get; set; } // SQLite stores booleans as 0 or 1

        public string LentTo { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }

        public string Notes { get; set; }
    }
}


