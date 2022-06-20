using BeerAPI.Data.Helpers;
using BeerAPI.Data.Interfaces;
using BeerAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BeerAPI.Data.Repositories
{
    public class TradeMarkRepo : ITradeMarkRepo
    {
        private readonly SqlConfiguration _sqlConfiguration;

        private static readonly string s_paramIdTradeMark = "@IdTradeMark";
        private static readonly string s_paramName = "@Name";
        private static readonly string s_queryGetTradeMark = "SELECT IdTradeMark, Name FROM TradeMark WHERE IdTradeMark = @IdTradeMark;";
        private static readonly string s_queryGetTradeMarks = "SELECT IdTradeMark, Name FROM TradeMark;";
        private static readonly string s_queryInsertTradeMarks = "INSERT INTO TradeMark(Name) VALUES(@Name);";
        private static readonly string s_queryUpdateTradeMark = "UPDATE TradeMark SET Name = @Name WHERE IdTradeMark = @IdTradeMark;";
        private static readonly string s_queryDeleteTradeMark = "DELETE FROM TradeMark WHERE IdTradeMark = @IdTradeMark;";

        public TradeMarkRepo(SqlConfiguration _) => _sqlConfiguration = _;

        protected SqlConnection DbConnection() => new(_sqlConfiguration.ConnectionString);

        public async Task<bool> DeleteTradeMark(int id)
        {
            SqlParameter paramIdTradeMark = new(s_paramIdTradeMark, SqlDbType.Int);
            paramIdTradeMark.Value = id;

            var result = await SqlHelper.ExecuteNonQueryTransactionAsync(DbConnection(), s_queryDeleteTradeMark, CommandType.Text, paramIdTradeMark);
            return result > 0;
        }

        public async Task<IEnumerable<TradeMark>> GetTradeMarks()
        {
            using SqlDataReader reader = await SqlHelper.ExecuteReaderAsync(DbConnection(), s_queryGetTradeMarks, CommandType.Text);
            return ReadItems(reader).ToArray();
        }

        public async Task<TradeMark> GetTradeMark(int id)
        {
            SqlParameter paramIdTradeMark = new(s_paramIdTradeMark, SqlDbType.Int);
            paramIdTradeMark.Value = id;
            using SqlDataReader reader = await SqlHelper.ExecuteReaderAsync(DbConnection(), s_queryGetTradeMark, CommandType.Text, paramIdTradeMark);
            return ReadItems(reader).First();
        }

        public async Task<bool> InsertTradeMark(TradeMark tradeMark)
        {
            SqlParameter paramName = new(s_paramName, SqlDbType.Text);
            paramName.Value = tradeMark.Name;

            var result = await SqlHelper.ExecuteNonQueryTransactionAsync(DbConnection(), s_queryInsertTradeMarks, CommandType.Text, paramName);
            return result > 0;
        }

        public async Task<bool> UpdateTradeMark(TradeMark tradeMark)
        {
            SqlParameter paramName = new(s_paramName, SqlDbType.Text);
            paramName.Value = tradeMark.Name;

            SqlParameter paramIdTradeMark = new(s_paramIdTradeMark, SqlDbType.Int);
            paramIdTradeMark.Value = tradeMark.IdTradeMark;

            var result = await SqlHelper.ExecuteNonQueryTransactionAsync(DbConnection(), s_queryUpdateTradeMark, CommandType.Text, paramName, paramIdTradeMark);
            return result > 0;
        }

        private static IEnumerable<TradeMark> ReadItems(SqlDataReader reader)
        {
            while (reader.Read())
            {
                TradeMark tradeMark = new()
                {
                    IdTradeMark = reader.GetInt32(0),
                    Name = reader.GetString(1)
                };
                yield return tradeMark;
            }
        }
    }
}
