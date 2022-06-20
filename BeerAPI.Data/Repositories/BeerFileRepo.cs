using BeerAPI.Data.Interfaces;
using BeerAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeerAPI.Data.Repositories
{
    public class BeerFileRepo : IBeerFileRepo
    {
        public Task<bool> DeleteBeerFile(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BeerFile>> GetBeerFile()
        {
            throw new NotImplementedException();
        }

        public Task<BeerFile> GetBeerFile(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertBeerFile(BeerFile beerFile)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateBeerFile(BeerFile beerFile)
        {
            throw new NotImplementedException();
        }
    }
}
