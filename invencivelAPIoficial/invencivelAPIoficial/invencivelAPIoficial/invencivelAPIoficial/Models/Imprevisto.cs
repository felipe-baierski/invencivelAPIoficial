using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Unicode;

namespace invencivelAPIoficial.Models
{
    [Table("Imprevisto")]
    public class Imprevisto
    {
        public int Imprevisto_id { get; set; }
        public string Imprevisto_nome { get; set; }
    }

//    CREATE TABLE IF NOT EXISTS Imprevisto(
//  ImprevistoID INT NOT NULL,
//  ImprevistoNome VARCHAR(200) NOT NULL,
//  PRIMARY KEY(ImprevistoID)
//) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
}
