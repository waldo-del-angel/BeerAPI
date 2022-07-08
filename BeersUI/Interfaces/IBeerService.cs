using BeerAPI.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeersUI.Interfaces
{
    public interface IBeerService
    {
        [Get("/api/Beer")]
        Task<IEnumerable<Beer>> GetBeers();
    }
}
