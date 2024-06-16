using PGE_V2.Dados;
using PGE_V2.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGE_V2.Controler
{
    public class UsuarioController
    {
        public static void Salvar_DadosPessoais(string Nº_BI, string Nome_Completo, string Filho_de, string E_de,string Data_nasc, string Genero)
        {
            SqlConnection connectionString = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; "); ;
            SqlCommand comando;
            string strSQL;

            strSQL = "INSERT INTO Dados_Pessoais (Nº_BI, Nome_Completo, Filho_de, E_de, Data_nasc, Genero)" +
                "VALUES (@Nº_BI, @Nome_Completo, @Filho_de, @E_de, @Data_nasc, @Genero)";
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

        public static DataTable Salvar_Multa(int Id_Login,int Nº_Doc, string Descricao_Multa)
        {
            SqlConnection connectionString = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; "); ;
            SqlCommand comando;
            string strSQL;
            DataTable dt = new DataTable();

            connectionString = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
            strSQL = "INSERT INTO Multa (Id_Login,Nº_Doc, Descricao_Multa) VALUES (@Id_Login,@Nº_Doc, @Descricao_Multa)";
            comando = new SqlCommand(strSQL, connectionString);

            comando.Parameters.AddWithValue("@Id_Login", Id_Login);
            comando.Parameters.AddWithValue("@Nº_Doc", Nº_Doc);
            comando.Parameters.AddWithValue("@Descricao_Multa", Descricao_Multa);


            connectionString.Open();
            comando.ExecuteNonQuery();

            return dt;
            connectionString.Close();
        }

        public static DataTable Salvar_Documento(string Num_Documento, string Descricao)
        {
            SqlConnection connectionString = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; "); ;
            SqlCommand comando;
            //SqlDataReader dr;
            string strSQL;

            DataTable dt = new DataTable();

            connectionString = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
            strSQL = "INSERT INTO Tipo_Documento (Nº_Documento,Estado, Descricao_Tipo_Documento) VALUES (@Nº_Documento,@Estado, @Descricao_Tipo_Documento)";
            comando = new SqlCommand(strSQL, connectionString);

            //comando.Parameters.AddWithValue("@Nº_Documento", label2.Text);
            comando.Parameters.AddWithValue("@Nº_Documento", $"{Num_Documento}");
            comando.Parameters.AddWithValue("@Estado", 1);
            comando.Parameters.AddWithValue("@Descricao_Tipo_Documento", $"{Descricao}");


            connectionString.Open();
            comando.ExecuteNonQuery();

            connectionString.Close();
            return dt;
        }

        public static DataTable Salvar_Detencao(int Id_DadosPessoais, string Detalhes_Detecao)
        {
            SqlConnection connectionString = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; "); ;
            SqlCommand comando;
            string strSQL;
            DataTable dt = new DataTable();

            connectionString = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; ");
            strSQL = "INSERT INTO Detecao (Id_Dados_Pessoais,Id_Login, Detalhes_Detecao) VALUES (@Id_Dados_Pessoais,@Id_Login, @Detalhes_Detecao)";
            comando = new SqlCommand(strSQL, connectionString);

            comando.Parameters.AddWithValue("@Id_Dados_Pessoais", Id_DadosPessoais);
            comando.Parameters.AddWithValue("@Id_Login", 1);
            comando.Parameters.AddWithValue("@Detalhes_Detecao", Detalhes_Detecao);


            connectionString.Open();
            comando.ExecuteNonQuery();

            connectionString.Close();
            return dt;
        }

        public static int Pesquisar_IDDadosPessoais(string Numero_BI)
        {
            int idDadosPessoais = -1; // Padrão, caso o usuario não seja encontrado

            using (var conexao = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True; "))
            {
                conexao.Open();
                var strSQL = "SELECT Id_Dados_Pessoais FROM Dados_Pessoais WHERE Nº_BI = @Nº_BI";
                using (var comando = new SqlCommand(strSQL, conexao))
                {
                    comando.Parameters.AddWithValue("@Nº_BI", Numero_BI);
                    using (var reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idDadosPessoais = Convert.ToInt32(reader["Id_Dados_Pessoais"]);
                        }
                    }
                }
            }

            return idDadosPessoais;
        }
    }

}
