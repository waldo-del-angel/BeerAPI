using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BeerAPI.Data.Helpers
{
    public static class SqlHelper
    {
        /// <summary>
        /// Set the connection, command, and then execute the command with non query.
        /// </summary>
        /// <param name="connection">Database connection</param>
        /// <param name="commandText">Query to execute</param>
        /// <param name="commandType">String command interpretation</param>
        /// <param name="parameters">SQL Parameters</param>
        /// <returns></returns>
        public async static Task<int> ExecuteNonQueryAsync(SqlConnection connection, String commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using SqlConnection conn = connection;
            using SqlCommand cmd = new(commandText, conn);
            // There're three command types: StoredProcedure, Text, TableDirect.
            // The TableDirect type is only for OLE DB.
            cmd.CommandType = commandType;
            cmd.Parameters.AddRange(parameters);
            await conn.OpenAsync();
            return await cmd.ExecuteNonQueryAsync();
        }

        /// <summary>
        /// Set the connection, command, and then execute the command with non query (with transaction).
        /// </summary>
        /// <param name="connection">Database connection</param>
        /// <param name="commandText">Query to execute</param>
        /// <param name="commandType">String command interpretation</param>
        /// <param name="parameters">SQL Parameters</param>
        /// <returns></returns>
        public async static Task<int> ExecuteNonQueryTransactionAsync(SqlConnection connection, String commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            using SqlConnection conn = connection;
            conn.Open();

            // Start a local transaction.
            SqlTransaction transaction = connection.BeginTransaction();

            // Must assign both transaction object and connection
            // to Command object for a pending local transaction
            using SqlCommand cmd = new(commandText, conn, transaction);

            // There're three command types: StoredProcedure, Text, TableDirect.
            // The TableDirect type is only for OLE DB.
            cmd.CommandType = commandType;
            cmd.Parameters.AddRange(parameters);
            
            try
            {
                var result = await cmd.ExecuteNonQueryAsync();
                await transaction.CommitAsync();
                return result;
            }
            catch (Exception ex)
            {
                // Attempt to roll back the transaction.
                try
                {
                    transaction.Rollback();
                    throw new Exception(ex.Message);
                }
                catch (Exception ex2)
                {
                    // This catch block will handle any errors that may have occurred
                    // on the server that would cause the rollback to fail, such as
                    // a closed connection.
                    throw new Exception(ex2.Message);
                }
            }
        }

        /// <summary>
        /// Set the connection, command, and then execute the command and only return one value. 
        /// </summary>
        /// <param name="connection">Database connection</param>
        /// <param name="commandText">Query to execute</param>
        /// <param name="commandType">String command interpretation</param>
        /// <param name="parameters">SQL Parameters</param>
        /// <returns></returns>        
        public async static Task<object> ExecuteScalarAsync(SqlConnection connection, String commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            using SqlConnection conn = connection;
            using SqlCommand cmd = new(commandText, conn);
            cmd.CommandType = commandType;
            cmd.Parameters.AddRange(parameters);
            await conn.OpenAsync();
            return await cmd.ExecuteScalarAsync();
        }

        /// <summary>
        /// Set the connection, command, and then execute the command with query and return the reader. 
        /// </summary>
        /// <param name="connection">Database connection</param>
        /// <param name="commandText">Query to execute</param>
        /// <param name="commandType">String command interpretation</param>
        /// <param name="parameters">SQL Parameters</param>
        /// <returns></returns>        
        public async static Task<SqlDataReader> ExecuteReaderAsync(SqlConnection connection, String commandText, CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection conn = connection;
            using SqlCommand cmd = new(commandText, conn);
            cmd.CommandType = commandType;
            cmd.Parameters.AddRange(parameters);
            await conn.OpenAsync();
            // When using CommandBehavior.CloseConnection, the connection will be closed when the   
            // IDataReader is closed.  
            return await cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection);
        }
    }
}
