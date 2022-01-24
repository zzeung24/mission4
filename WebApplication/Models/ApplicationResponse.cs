using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lentto { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }

    }
}
