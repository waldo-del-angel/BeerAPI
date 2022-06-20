using System;
using System.ComponentModel.DataAnnotations;

namespace BeerAPI.Models
{
    public class BeerFile
    {
        public int IdBeerFile { get; set; }
        
        [Required]
        public string Path { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public string TypeFile { get; set; }

        [Required]
        public Beer Beer { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdateAt { get; set; }
    }
}
