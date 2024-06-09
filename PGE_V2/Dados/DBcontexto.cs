using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGE_V2.Dados
{
    public class DBcontexto
    {
        // colocar no utils mais tarde
        public string stringDeConexao {  get; set; }

        public DBcontexto()
        {
            stringDeConexao = "Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ";
        }

        //private readonly DBcontexto;
    }
}
