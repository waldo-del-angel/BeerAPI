using System.ComponentModel.DataAnnotations;

namespace BeerAPI.Models
{
    public class TradeMark
    {
        public int IdTradeMark { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
