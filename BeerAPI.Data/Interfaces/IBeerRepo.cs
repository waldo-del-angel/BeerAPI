using BeerAPI.Models;
using BeerAPI.Models.Views;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeerAPI.Data.Interfaces
{
    public interface IBeerRepo
    {
        Task<IEnumerable<BeerTradeMark>> GetBeers();
        Task<BeerTradeMark> GetBeer(int id);
        Task<bool> InsertBeer(Beer beer);
        Task<bool> UpdateBeer(Beer beer);
        Task<bool> DeleteBeer(int id);
    }
}
