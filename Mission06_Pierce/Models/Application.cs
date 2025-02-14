using System.ComponentModel.DataAnnotations;

namespace Mission06_Pierce.Models
{
    public class Application
    {
        [Key]
        public int MovieId { get; set; } // Primary Key

        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; } // Dropdown: G, PG, PG-13, R

        public bool Edited { get; set; } // Optional Yes/No

        public string? LentTo { get; set; } // Optional

        [MaxLength(25)]
        public string? Notes { get; set; } // Optional, max 25 chars
    }
}
