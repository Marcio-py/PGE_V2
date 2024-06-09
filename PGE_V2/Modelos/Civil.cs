using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGE_V2.Modelos
{
    public class Civil
    {
        [Key]
        public int Id_Dados_Pessoais { get; set; }
        public string Nome_Completo { get; set; }
        public string Filho_de { get; set; }
        public string E_de { get; set; }
        //public string? Image { get; set; }
        public DateTime? Data_Nasc { get; set; }
        public int? Genero { get; set; }
        public string? Id_Endereco { get; set; }
        public int? Nº_BI { get; set; }

    }
}
