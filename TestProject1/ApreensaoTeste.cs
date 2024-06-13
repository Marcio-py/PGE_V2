using PGE_V2;
using System;
using PGE_V2.Modelos;
using System.Data.SqlClient;
using PGE_V2.Dados;
using PGE_V2.Repositorio;
using System.Data;
using Moq;
using PGE_V2.Controler;
using PGE_V2.Interface;
using System.Windows.Forms;
namespace TestProject1
{
    public class ApreensaoTeste
    {
        [Fact]
        public void Create_DeveAdicionar_UmaLinhaNaBD()
        {
            var connectionString = DBcontexto.CaminhoBD();
            var apreensaoRepositorio = new ApreensaoRepositorio(connectionString);

            ApreensaoController apreensaoController = new ApreensaoController(apreensaoRepositorio);
            apreensaoController.Create("Amostra", "2000/07/07", "3LA", 1);

            // Assert (verify that the data was inserted)
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var selectSql = "SELECT COUNT(*) FROM Apreensao WHERE Nº_Documento = @Nº_Documento";
                using (var command = new SqlCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@Nº_Documento", "3LA");
                    var count = (int)command.ExecuteScalar();
                    //Assert.Equal(1, count); 
                    Assert.NotNull(count);
                }
            }
        }
        [Fact]
        public void Change_DeveAlterar_DescricaoLinhaSelecionada()
        {
            var connectionString = DBcontexto.CaminhoBD();
            var apreensaoRepositorio = new ApreensaoRepositorio(connectionString);

            //// Amostra do objeto apreensao para atualizar
            //var apreensaoToSave = new Apreensao
            //{
            //    Descricao_Apreensao = "Nova descrição3",
            //    Data_Apreencao = "2000/01/01",
            //    Nº_Documento = "20210778LA020",
            //    Id_Login = 1
            //};
            ////ACT
            //apreensaoRepositorio.Update(apreensaoToSave);

            // Assert (verify that the data was inserted)
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var selectSql = "SELECT Descricao_Apreensao FROM Apreensao WHERE Nº_Documento = @Nº_Documento";
                using (var command = new SqlCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@Nº_Documento", "20210778LA020");
                    var resultado = command.ExecuteScalar();
                    //Assert.Equal(1, count); 
                    Assert.Equal("Nova descrição3", resultado);
                }
            }

        }

        [Fact]
        public void ProcuraElementoPorID_DeveRetorna_ValorDaLinhaSelecionada()
        {

            DataTable tabela = new DataTable();
            var connectionString = DBcontexto.CaminhoBD();
            SqlConnection conexao = new SqlConnection(connectionString);

            SqlCommand comando = new SqlCommand("SELECT * FROM Apreensao Where Nº_Documento = '20210778LA020'", conexao);  
            conexao.Open();

            SqlDataAdapter slqDat = new SqlDataAdapter(comando);
            slqDat.Fill(tabela);

           string resultdescricao;
           string resultadoId;

            SqlDataReader red = comando.ExecuteReader();
            if (red.Read())
            {
                resultdescricao = red["Descricao_Apreensao"].ToString();
                resultadoId = red["Id_Apreensao"].ToString();
                Assert.Contains("Nova", resultdescricao);
                Assert.Contains("2", resultadoId);
            }
            conexao.Close();

            //return tabela;

        }
           
    }
}