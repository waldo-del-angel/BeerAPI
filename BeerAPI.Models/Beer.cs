using System.ComponentModel.DataAnnotations;

namespace BeerAPI.Models
{
    public class Beer
    {
        public int IdBeer { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int IdTradeMark { get; set; }

        public TradeMark TradeMark { get; set; }
    }
}
