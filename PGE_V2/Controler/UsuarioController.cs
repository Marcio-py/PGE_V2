using PGE_V2.Dados;
using PGE_V2.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGE_V2.Controler
{
    public class UsuarioController
    {
        
        private readonly UsuarioInterface _UsuarioRepository;

        public static void Salvar_DadosPessoais(int Nº_BI, string Nome_Completo, string Filho_de, string E_de,string Data_nasc, string Genero)
        {
            SqlConnection connectionString = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; "); ;
            SqlCommand comando;
            //SqlDataReader dr;
            string strSQL;

            strSQL = "INSERT INTO Dados_Pessoais (Nº_BI, Nome_Completo, Filho_de, E_de, Data_nasc, Genero) VALUES (@Nº_BI, @Nome_Completo, @Filho_de, @E_de, @Data_nasc, @Genero)";
            comando = new SqlCommand(strSQL, connectionString);

            comando.Parameters.AddWithValue("@Nº_BI", Nº_BI);
            comando.Parameters.AddWithValue("@Nome_Completo", Nome_Completo);
            comando.Parameters.AddWithValue("@Filho_de", Filho_de);
            comando.Parameters.AddWithValue("@e_de", E_de);
            comando.Parameters.AddWithValue("@Data_nasc", Data_nasc);
            comando.Parameters.AddWithValue("@genero", Genero);

            connectionString.Open();
            comando.ExecuteNonQuery();

            connectionString.Close();
        }
    }

}
