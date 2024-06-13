using PGE_V2.Dados;
using PGE_V2.Interface;
using PGE_V2.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PGE_V2.Repositorio
{
    public class ApreensaoRepositorio : IApreensaoRepositorio
    {
        private readonly string _connectionString;

        public ApreensaoRepositorio(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Apreensao apreensao)
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True;");
            connection.Open();

                // Assuming you have a table named 'Apreensao' in your database
                var sql = "INSERT INTO Apreensao (Descricao_Apreensao, Data_Apreencao, Nº_Documento, Id_Login) " +
                          "VALUES ( @Descricao, @Data, @Nº_Documento, @Id_Login)";

                using (var command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@Descricao", apreensao.Descricao_Apreensao);
                    command.Parameters.AddWithValue("@Data", apreensao.Data_Apreencao ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Nº_Documento", apreensao.Nº_Documento);
                    command.Parameters.AddWithValue("@Id_Login", apreensao.Id_Login);

                    command.ExecuteNonQuery();

                }

        }
     
        public DataTable BuscarPorId(string Num_Documento)
        {
            DataTable tabela = new DataTable();
            try
            {
            var connectionString = DBcontexto.CaminhoBD();
            SqlConnection conexao = new SqlConnection(connectionString);

            SqlCommand comando = new SqlCommand($"SELECT * FROM Apreensao Where Nº_Documento = '{Num_Documento}'", conexao);
            conexao.Open();

            SqlDataAdapter slqDat = new SqlDataAdapter(comando);
            slqDat.Fill(tabela);

            string resultado;

            comando.ExecuteReader();

            conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            return tabela;
        }

        public void Delete(Apreensao apreensao)
        {
            SqlConnection ConnetionString;
            SqlCommand comando;
            string strSQL;
            ConnetionString = new SqlConnection(DBcontexto.CaminhoBD());

            try
            {
                ConnetionString = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True;");
                strSQL = "Delete Apreensao WHERE Nº_Documento = @Nº_Documento";
                comando = new SqlCommand(strSQL, ConnetionString);

                comando.Parameters.AddWithValue("@Nº_Documento", apreensao.Nº_Documento);

                ConnetionString.Open();
                comando.ExecuteNonQuery();
                //MessageBox.Show("Apagado com Sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnetionString.Close();
                ConnetionString = null;
                comando = null;
            }
        }


        public void Update(Apreensao apreensao)
        {
            SqlConnection ConnetionString;
            SqlCommand comando;
            string strSQL;
            ConnetionString = new SqlConnection("Server=DESKTOP-Q4CIO9V\\SQLEXPRESS;Database=Sistema_Gestao_Esquadra;Trusted_Connection=True;");
            try
            {

                strSQL = "UPDATE Apreensao SET Data_Apreencao = @Data, Descricao_Apreensao = @Descricao WHERE Nº_Documento = @Nº_Documento";
                comando = new SqlCommand(strSQL, ConnetionString);

                comando.Parameters.AddWithValue("@Descricao", apreensao.Descricao_Apreensao);
                comando.Parameters.AddWithValue("@Data", apreensao.Data_Apreencao ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@Nº_Documento", apreensao.Nº_Documento);

                ConnetionString.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnetionString.Close();
                ConnetionString = null;
                comando = null;
            }
        }


        public DataTable BuscarPorId_RetornaUmaLinha(string Num_Documento)
        {
            DataTable tabela = new DataTable();
            var connectionString = DBcontexto.CaminhoBD();
            SqlConnection conexao = new SqlConnection(connectionString);

            SqlCommand comando = new SqlCommand($"SELECT * FROM Apreensao Where Nº_Documento = '{Num_Documento}'", conexao);
            conexao.Open();

            SqlDataAdapter slqDat = new SqlDataAdapter(comando);
            slqDat.Fill(tabela);

            string resultado;

            SqlDataReader red = comando.ExecuteReader();
            conexao.Close();

            return tabela;
        }
    }
}
