
using Dapper;
using invencivelAPIoficial.Models;
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

        public async Task<ImprevistoModel> UltimoCodigoAcidente()
        {
//            var sql = @"
//INSERT INTO Imprevisto 
//(Imprevisto_nome, Imprevisto_tipo, Imprevisto_data, Imprevisto_gravidade, Imprevisto_local, Imprevisto_descricao)
//VALUES
//(@nome, @tipo, @data, @gravidade, @local, @descricao);";

//            await _db.ExecuteAsync(sql, new
//            {
//                nome = "Pane elétrica no sistema",
//                tipo = "Falha Técnica",
//                data = DateTime.Now,
//                gravidade = "Alta",
//                local = "Setor 3 - Linha Principal",
//                descricao = "Falha elétrica inesperada que interrompeu as operações."
//            });
            var sql = "SELECT *\r\nFROM Imprevisto\r\nORDER BY Imprevisto_id\r\nLIMIT 1;";

            var rows = await _db.QueryFirstOrDefaultAsync<ImprevistoModel>(sql);



            //foreach (var row in rows)
            //{
            //    Console.WriteLine($"{row.Field} - {row.Type}");
            //}

            return rows;
        }
    }
}
