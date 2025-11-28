
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Data;
using System.Text;
using System.Text.Json;

namespace invencivelAPIoficial.Services
{
    public class ImprevistoService : Imprevisto
    {
        private readonly IDbConnection _db;

        public ImprevistoService(IDbConnection dbConnection)
        {
            _db = dbConnection;
        }

        public async Task<bool> UltimoCodigoAcidente()
        {
            var sql = "INSERT INTO Imprevisto (\r\n    Imprevisto_nome,\r\n    Imprevisto_tipo,\r\n    Imprevisto_data,\r\n    Imprevisto_gravidade,\r\n    Imprevisto_local,\r\n    Imprevisto_descricao\r\n)\r\nVALUES\r\n-- 1\r\n(\r\n    'Acidente Leve',\r\n    'Colisão traseira',\r\n    '2025-01-10 08:32:00',\r\n    'Baixa',\r\n    'Avenida Brasil - KM 12',\r\n    'Dois veículos envolvidos, sem feridos.'\r\n)";

            var criarcoluns = await _db.QueryAsync(sql);

            return true;
        }
    }
}
