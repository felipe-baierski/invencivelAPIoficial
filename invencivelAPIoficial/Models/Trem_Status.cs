using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Unicode;

namespace invencivelAPIoficial.Models
{
    [Table("Trem_status")]
    public class Trem_Status
    {
        public int Trem_id { get; set; }
        public string Trem_cor { get; set; }
        public double Trem_velocidade { get; set; }
        public string Trem_KmRodado { get; set; }
        public string? Trem_lugarVisita { get; set; }
        public float Trem_pasagem { get; set; }

    }

//    CREATE TABLE IF NOT EXISTS Trem_Status(
//  TremId INT NOT NULL AUTO_INCREMENT,
//  TremCor VARCHAR(45) NOT NULL,
//  TremVagao INT NOT NULL,
//  TremVelocidade DOUBLE NOT NULL,
//  TremKmRodado VARCHAR(200) NOT NULL,
//  TremLugarVisita JSON NULL DEFAULT NULL,
//  TremPassagem FLOAT NOT NULL,
//  PRIMARY KEY(TremId)
//) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;
}
