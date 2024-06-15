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
            var sql = "INSERT INTO Apreensao (Descricao_Apreensao, Data_Apreencao, Nº_Documento, Id_Login) " +
                      "VALUES ( @Descricao, @Data, @Nº_Documento, @Id_Login)";
            using (SqlConnection connection = new SqlConnection(DBcontexto.CaminhoBD()))
            using (var command = new SqlCommand(sql, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Descricao", apreensao.Descricao_Apreensao);
                    command.Parameters.AddWithValue("@Data", apreensao.Data_Apreencao ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Nº_Documento", apreensao.Nº_Documento);
                    command.Parameters.AddWithValue("@Id_Login", apreensao.Id_Login);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public DataTable BuscarPorId(Apreensao apreensao)
        {
            using (SqlConnection connection = new SqlConnection(DBcontexto.CaminhoBD()))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Apreensao WHERE Nº_Documento = @NumDocumento", connection))
            {
                command.Parameters.AddWithValue("@NumDocumento", apreensao.Nº_Documento);

                DataTable tabela = new DataTable();

                try
                {
                    connection.Open();
                    using (SqlDataAdapter sqlDat = new SqlDataAdapter(command))
                    {
                        sqlDat.Fill(tabela);
                    }
                    return tabela;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return tabela;
                }
            }
        }

        public void Update(Apreensao apreensao)
        {
            string strSQL = "UPDATE Apreensao SET Data_Apreencao = @Data, Descricao_Apreensao = @Descricao WHERE Nº_Documento = @Nº_Documento";

            using (SqlConnection connection = new SqlConnection(DBcontexto.CaminhoBD()))
            using (SqlCommand command = new SqlCommand(strSQL, connection))
            {
                command.Parameters.AddWithValue("@Descricao", apreensao.Descricao_Apreensao);
                command.Parameters.AddWithValue("@Data", apreensao.Data_Apreencao ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Nº_Documento", apreensao.Nº_Documento);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Delete(Apreensao apreensao)
        {
            string strSQL = "DELETE FROM Apreensao WHERE Nº_Documento = @Nº_Documento";

            using (SqlConnection connection = new SqlConnection(DBcontexto.CaminhoBD()))
            using (SqlCommand command = new SqlCommand(strSQL, connection))
            {
                command.Parameters.AddWithValue("@Nº_Documento", apreensao.Nº_Documento);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
