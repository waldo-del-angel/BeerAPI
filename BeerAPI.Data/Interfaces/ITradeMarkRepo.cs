using BeerAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeerAPI.Data.Interfaces
{
    public interface ITradeMarkRepo
    {
        Task<IEnumerable<TradeMark>> GetTradeMarks();
        Task<TradeMark> GetTradeMark(int id);
        Task<bool> InsertTradeMark(TradeMark tradeMark);
        Task<bool> UpdateTradeMark(TradeMark tradeMark);
        Task<bool> DeleteTradeMark(int id);
    }
}
