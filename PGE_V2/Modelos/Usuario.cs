using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGE_V2.Modelos
{
    public class Usuario
    {
        public int Id_Funcionario { get; set; }
        public int? Estado { get; set; }
        public string? Id_Funcao { get; set; }
        public string? Id_Login { get; set; }
        public string? Id_endereco { get; set; }
    }
}
