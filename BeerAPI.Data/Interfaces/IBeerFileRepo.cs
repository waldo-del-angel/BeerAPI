using BeerAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeerAPI.Data.Interfaces
{
    public interface IBeerFileRepo
    {
        Task<IEnumerable<BeerFile>> GetBeerFile();
        Task<BeerFile> GetBeerFile(int id);
        Task<bool> InsertBeerFile(BeerFile beerFile);
        Task<bool> UpdateBeerFile(BeerFile beerFile);
        Task<bool> DeleteBeerFile(int id);
    }
}
