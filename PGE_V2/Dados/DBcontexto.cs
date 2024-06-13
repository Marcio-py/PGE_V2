using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGE_V2.Dados
{
    public class DBcontexto
    {
        // colocar no utils mais tarde 
        // private readonly string _stringDeConexao = Environment.GetEnvironmentVariable("BDDESTINO");

        public DBcontexto(string stringDeConexao)
        {
            //_stringDeConexao = stringDeConexao;
        }

        public static string CaminhoBD()
        {
            DotNetEnv.Env.TraversePath().Load();
           string stringBD;
           return  stringBD = Environment.GetEnvironmentVariable("BDDESTINO");
        }

        public bool Verifica_Registo_DoCidadao(string numeroBI)
        {
            using (SqlConnection conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True;"))
            {
                conexao.Open();
                string strSQL = "SELECT COUNT(*) FROM Tipo_Documento WHERE Nº_Documento = @Nº_Documento";
                using (SqlCommand comando = new SqlCommand(strSQL, conexao))
                {
                    comando.Parameters.AddWithValue("@Nº_Documento", numeroBI);
                    int count = (int)comando.ExecuteScalar();

                    // Check if the count is greater than 0 (record exists)
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Apreensão negada: O cívil não tem nenhum registo");
                        return false;
                    }
                }
            }
        }

        public static void ConverteStringParaData(string Data)
        {
            DateTime myDateTime = DateTime.Now; // Replace with your actual DateTime value

            // Get the date portion in yyyy-MM-dd format
            string formattedDate = myDateTime.ToString("yyyy-MM-dd");
        }
    }
}
