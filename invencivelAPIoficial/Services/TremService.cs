using Dapper;
using invencivelAPIoficial.Models;
using System.Data;

namespace invencivelAPIoficial.Services
{
    public class TremService : TremInterface
    {
        private readonly IDbConnection _db;

        public TremService(IDbConnection dbConnection)
        {
            _db = dbConnection;
        }

        public async Task<List<string>> ObterTremNomesTrem()
        {

            var sql = "SELECT Nome_trem FROM Trem";

            var tremNomes = await _db.QueryAsync<string>(sql);

            return tremNomes.ToList();
        }
    }
}
