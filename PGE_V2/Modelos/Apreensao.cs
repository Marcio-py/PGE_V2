using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGE_V2.Modelos
{
    public class Apreensao 
    {
        [Key]
        public int Id_Apreensao { get; set; }
        public string Descricao_Apreensao { get; set; }
        public string? Data_Apreencao { get; set; }
        public string? Nº_Documento { get; set; }
        public int? Id_Login { get; set; }

    }
}
