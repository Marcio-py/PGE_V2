using PGE_V2.Dados;
using PGE_V2.Interface;
using PGE_V2.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGE_V2.Repositorio
{
    public class CivilRepositorio : ICivilRepositorio
    {
        private readonly string _connectionString;

        public CivilRepositorio(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Civil civil)
        {
            var sql = "INSERT INTO Dados_Pessoais (Nº_BI, Nome_Completo, Filho_de, E_de, Data_nasc, Genero) " +
                "VALUES (@Nº_BI, @Nome_Completo, @Filho_de, @E_de, @Data_nasc, @Genero)"; 
            using (SqlConnection connection = new SqlConnection(DBcontexto.CaminhoBD()))
            using (var command = new SqlCommand(sql, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Nº_BI", civil.Nº_BI);
                    command.Parameters.AddWithValue("@Nome_Completo", civil.Nome_Completo);
                    command.Parameters.AddWithValue("@Filho_de", civil.Filho_de);
                    command.Parameters.AddWithValue("@e_de", civil.E_de);
                    command.Parameters.AddWithValue("@Data_nasc", civil.Data_Nasc);
                    command.Parameters.AddWithValue("@genero", civil.Genero);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public DataTable BuscarPorId(Civil civil)
        {
            using (SqlConnection connection = new SqlConnection(DBcontexto.CaminhoBD()))
            using (SqlCommand command = new SqlCommand("SELECT * FROM Dados_Pessoais WHERE Nº_BI = @NumDocumento", connection))
            {
                DataTable tabela = new DataTable();
                try
                {
                    command.Parameters.AddWithValue("@NumDocumento", civil.Nº_BI);
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

        public void Update(Civil civil)
        {
            string sql = "UPDATE Dados_Pessoais SET Nome_Completo = @Nome_Completo, Filho_de = @Filho_de,e_de = @e_de,Data_nasc = @Data_nasc,genero = @genero  WHERE Nº_BI = @Nº_BI";
            using (SqlConnection connection = new SqlConnection(DBcontexto.CaminhoBD()))
            using (var command = new SqlCommand(sql, connection))
            {
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Nº_BI", civil.Nº_BI);
                    command.Parameters.AddWithValue("@Nome_Completo", civil.Nome_Completo);
                    command.Parameters.AddWithValue("@Filho_de", civil.Filho_de);
                    command.Parameters.AddWithValue("@e_de", civil.E_de);
                    command.Parameters.AddWithValue("@Data_nasc", civil.Data_Nasc);
                    command.Parameters.AddWithValue("@genero", civil.Genero);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void Delete(Civil civil)
        {
            string strSQL = "DELETE FROM Dados_Pessoais WHERE Nº_BI = @Nº_BI";
            using (SqlConnection connection = new SqlConnection(DBcontexto.CaminhoBD()))
            using (SqlCommand command = new SqlCommand(strSQL, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@Nº_Documento", civil.Nº_BI);
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
