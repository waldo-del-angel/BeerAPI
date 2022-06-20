using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerAPI.Models.Views
{
    public class BeerTradeMark
    {
        public int IdBeer { get; set; }
        public string NameBeer { get; set; }
        public int IdTradeMark { get; set; }
        public string NameTradeMark { get; set; }
    }
}
