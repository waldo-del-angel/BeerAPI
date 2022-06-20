using BeerAPI.Data.Helpers;
using BeerAPI.Data.Interfaces;
using BeerAPI.Models;
using BeerAPI.Models.Views;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BeerAPI.Data.Repositories
{
    public class BeerRepo : IBeerRepo
    {
        private readonly SqlConfiguration _sqlConfiguration;

        private static readonly string s_table = "Beer";
        private static readonly string s_viewBeerTradeMark = "vBeerTradeMark";
        private static readonly string s_paramIdBeer = "@IdBeer";
        private static readonly string s_paramName = "@Name";
        private static readonly string s_paramIdTradeMark = "@IdTradeMark";
        private static readonly string s_queryGetBeer = $"SELECT * FROM {s_viewBeerTradeMark} WHERE IdBeer = {s_paramIdBeer};";
        private static readonly string s_queryGetBeers = $"SELECT * FROM {s_viewBeerTradeMark};";
        private static readonly string s_queryInsertBeer = $"INSERT INTO {s_table}(Name, IdTradeMark) VALUES({s_paramName}, {s_paramIdTradeMark});";
        private static readonly string s_queryUpdateBeer = $"UPDATE {s_table} SET Name = {s_paramName}, IdTradeMark = {s_paramIdTradeMark} WHERE IdBeer = {s_paramIdBeer};";
        private static readonly string s_queryDeleteBeer = $"DELETE FROM {s_table} WHERE IdBeer = {s_paramIdBeer};";

        public BeerRepo(SqlConfiguration _) => _sqlConfiguration = _;

        protected SqlConnection DbConnection() => new(_sqlConfiguration.ConnectionString);

        public async Task<bool> DeleteBeer(int id)
        {
            SqlParameter paramIdBeer = new(s_paramIdBeer, SqlDbType.Int);
            paramIdBeer.Value = id;

            var result = await SqlHelper.ExecuteNonQueryTransactionAsync(DbConnection(), s_queryDeleteBeer, CommandType.Text, paramIdBeer);
            return result > 0;
        }

        public async Task<IEnumerable<BeerTradeMark>> GetBeers()
        {
            using SqlDataReader reader = await SqlHelper.ExecuteReaderAsync(DbConnection(), s_queryGetBeers, CommandType.Text);
            return ReadItems(reader).ToArray();
        }

        public async Task<BeerTradeMark> GetBeer(int id)
        {
            SqlParameter paramIdBeer = new(s_paramIdBeer, SqlDbType.Int);
            paramIdBeer.Value = id;
            using SqlDataReader reader = await SqlHelper.ExecuteReaderAsync(DbConnection(), s_queryGetBeer, CommandType.Text, paramIdBeer);
            return ReadItems(reader).First();
        }

        public async Task<bool> InsertBeer(Beer beer)
        {
            SqlParameter paramName = new(s_paramName, SqlDbType.Text);
            paramName.Value = beer.Name;

            SqlParameter paramIdTradeMark = new(s_paramIdTradeMark, SqlDbType.Int);
            paramIdTradeMark.Value = beer.IdTradeMark;

            var result = await SqlHelper.ExecuteNonQueryTransactionAsync(DbConnection(), s_queryInsertBeer, CommandType.Text, paramName, paramIdTradeMark);
            return result > 0;
        }

        public async Task<bool> UpdateBeer(Beer beer)
        {
            SqlParameter paramName = new(s_paramName, SqlDbType.Text);
            paramName.Value = beer.Name;

            SqlParameter paramIdTradeMark = new(s_paramIdTradeMark, SqlDbType.Int);
            paramIdTradeMark.Value = beer.IdTradeMark;

            SqlParameter paramIdBeer = new(s_paramIdBeer, SqlDbType.Int);
            paramIdBeer.Value = beer.IdBeer;

            var result = await SqlHelper.ExecuteNonQueryTransactionAsync(DbConnection(), s_queryUpdateBeer, CommandType.Text, paramName, paramIdTradeMark, paramIdBeer);
            return result > 0;
        }

        private static IEnumerable<BeerTradeMark> ReadItems(SqlDataReader reader)
        {
            while (reader.Read())
            {
                BeerTradeMark tradeMark = new()
                {
                    IdBeer = reader.GetInt32(0),
                    NameBeer = reader.GetString(1),
                    IdTradeMark = reader.GetInt32(2),
                    NameTradeMark = reader.GetString(3)
                };
                yield return tradeMark;
            }
        }
    }
}
