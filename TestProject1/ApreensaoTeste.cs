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
        [Trait("Apreensão", "Create update read")]
        public void Create_DeveAdicionar_UmaLinhaNaBD()
        {
            // Arrange
            var apreensaoToSave = new Apreensao
            {
                Descricao_Apreensao = "Teste ad~ção",
                Data_Apreencao = "2000-04-04",
                Nº_Documento = "3LA",
            };

            // Act
            var connectionString = DBcontexto.CaminhoBD();
            var apreensaoRepositorio = new ApreensaoRepositorio(connectionString);
            ApreensaoController apreensaoController = new ApreensaoController(apreensaoRepositorio);
            int documentosRepetidos = apreensaoController.Find(apreensaoToSave.Nº_Documento).Rows.Count;
            // Se houver numeros de documentos repetidos cancela a operação
            if (documentosRepetidos > 0 )  { return; }
            { apreensaoController.Create(apreensaoToSave.Descricao_Apreensao, apreensaoToSave.Data_Apreencao, apreensaoToSave.Nº_Documento, 1); }
            documentosRepetidos = apreensaoController.Find(apreensaoToSave.Nº_Documento).Rows.Count;
            // Assert (Verificar se a informação foi adicionada)
            Assert.Equal(1, documentosRepetidos); 
        }
        [Fact]
        [Trait("Apreensão", "Create update read")]
        public void Change_DeveAlterar_DescricaoLinhaSelecionada()
        {
            // Arrange
            var apreensaoToSave = new Apreensao
            {
                Descricao_Apreensao = "Alterado",
                Data_Apreencao = "2000-04-04",
                Nº_Documento = "3LA",
            };
            //Act
            // Inicializar conexão  & executar operação
            var apreensaoRepositorio = new ApreensaoRepositorio(DBcontexto.CaminhoBD());
            ApreensaoController apreensaoController = new ApreensaoController(apreensaoRepositorio);
            apreensaoController.Change(apreensaoToSave.Descricao_Apreensao, apreensaoToSave.Data_Apreencao, apreensaoToSave.Nº_Documento);
            // Assert
            DataRow tabelaEncontrada = apreensaoController.Find(apreensaoToSave.Nº_Documento).Rows[0];
            string resultdescricao = tabelaEncontrada["Descricao_Apreensao"].ToString();
            Assert.Contains(apreensaoToSave.Descricao_Apreensao, resultdescricao);
        }

        [Fact]
        [Trait("Apreensão", "Create update read")]
        public void ProcuraElementoPorID_DeveRetorna_ValorDaLinhaSelecionada()
        {
            // Arrange
            var apreensaoToSave = new Apreensao
            {
                Descricao_Apreensao = "Alterado",
                Data_Apreencao = "2000-04-04",
                Nº_Documento = "3LA",
            };
            //Act

            // Inicializar conexão  & executar operação
            var apreensaoRepositorio = new ApreensaoRepositorio(DBcontexto.CaminhoBD());
            ApreensaoController apreensaoController = new ApreensaoController(apreensaoRepositorio);
            apreensaoController.Change(apreensaoToSave.Descricao_Apreensao, apreensaoToSave.Data_Apreencao, apreensaoToSave.Nº_Documento);
            DataRow tabelaEncontrada = apreensaoController.Find(apreensaoToSave.Nº_Documento).Rows[0];

            //Assert
            string resultdescricao = tabelaEncontrada["Descricao_Apreensao"].ToString();
            Assert.Equal(apreensaoToSave.Descricao_Apreensao, resultdescricao);
        }

        [Fact]
        [Trait("Apreensão", "metodo delete")]
        public void Delete_DeveEliminar_UmaLinhaNaBD()
        {
            // Arrange
            var apreensaoToSave = new Apreensao
            {
                Descricao_Apreensao = "Alterado",
                Data_Apreencao = "2000-04-04",
                Nº_Documento = "3LA",
            };
            //Act
            // Inicializar conexão  & executar operação
            var apreensaoRepositorio = new ApreensaoRepositorio(DBcontexto.CaminhoBD());
            ApreensaoController apreensaoController = new ApreensaoController(apreensaoRepositorio);
            apreensaoController.Delete(apreensaoToSave.Nº_Documento);
            int NumeroDeTabelas_Encontradas = apreensaoController.Find(apreensaoToSave.Nº_Documento).Rows.Count;

            //Assert
            // string resultadoId = tabelaEncontrada["Id_Apreensao"].ToString();
            Assert.True(NumeroDeTabelas_Encontradas == 0);
        }

    }
}