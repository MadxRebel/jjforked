using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Data.Sqlite;
using System.Data.OleDb;
using Dapper;
using System.Configuration;

namespace InventoryManagmentSystem.DataAccess
{
    public class SqliteDataAccess
    {
        public async Task SaveData<T>(string query, T Parameters)
        {
            
            using (IDbConnection  conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                await conn.ExecuteAsync(query, Parameters, commandType: CommandType.Text);
            }
            
        }

        public IEnumerable<T> LoadData<T, U>(string query, U Parameters)
        {
            using (IDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                return conn.Query<T>(query, Parameters, commandType: CommandType.Text);
            }
            
        }

        public bool TextExists<T, U>(string query, U parameters)
        {
            using (IDbConnection conn = new OleDbConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                return conn.ExecuteScalar<bool>(query, parameters, commandType: CommandType.Text);
            }
        }
        
    }
}