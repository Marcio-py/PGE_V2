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
        [Trait("Apreens�o", "Create update read")]
        public void Create_DeveAdicionar_UmaLinhaNaBD()
        {
            // Arrange
            var apreensaoToSave = new Apreensao
            {
                Descricao_Apreensao = "Teste ad~��o",
                Data_Apreencao = "2000-04-04",
                N�_Documento = "3LA",
            };

            // Act
            var connectionString = DBcontexto.CaminhoBD();
            var apreensaoRepositorio = new ApreensaoRepositorio(connectionString);
            ApreensaoController apreensaoController = new ApreensaoController(apreensaoRepositorio);
            int documentosRepetidos = apreensaoController.Find(apreensaoToSave.N�_Documento).Rows.Count;
            // Se houver numeros de documentos repetidos cancela a opera��o
            if (documentosRepetidos > 0 )  { return; }
            { apreensaoController.Create(apreensaoToSave.Descricao_Apreensao, apreensaoToSave.Data_Apreencao, apreensaoToSave.N�_Documento, 1); }
            documentosRepetidos = apreensaoController.Find(apreensaoToSave.N�_Documento).Rows.Count;
            // Assert (Verificar se a informa��o foi adicionada)
            Assert.Equal(1, documentosRepetidos); 
        }
        [Fact]
        [Trait("Apreens�o", "Create update read")]
        public void Change_DeveAlterar_DescricaoLinhaSelecionada()
        {
            // Arrange
            var apreensaoToSave = new Apreensao
            {
                Descricao_Apreensao = "Alterado",
                Data_Apreencao = "2000-04-04",
                N�_Documento = "3LA",
            };
            //Act
            // Inicializar conex�o  & executar opera��o
            var apreensaoRepositorio = new ApreensaoRepositorio(DBcontexto.CaminhoBD());
            ApreensaoController apreensaoController = new ApreensaoController(apreensaoRepositorio);
            apreensaoController.Change(apreensaoToSave.Descricao_Apreensao, apreensaoToSave.Data_Apreencao, apreensaoToSave.N�_Documento);
            // Assert
            DataRow tabelaEncontrada = apreensaoController.Find(apreensaoToSave.N�_Documento).Rows[0];
            string resultdescricao = tabelaEncontrada["Descricao_Apreensao"].ToString();
            Assert.Contains(apreensaoToSave.Descricao_Apreensao, resultdescricao);
        }

        [Fact]
        [Trait("Apreens�o", "Create update read")]
        public void ProcuraElementoPorID_DeveRetorna_ValorDaLinhaSelecionada()
        {
            // Arrange
            var apreensaoToSave = new Apreensao
            {
                Descricao_Apreensao = "Alterado",
                Data_Apreencao = "2000-04-04",
                N�_Documento = "3LA",
            };
            //Act

            // Inicializar conex�o  & executar opera��o
            var apreensaoRepositorio = new ApreensaoRepositorio(DBcontexto.CaminhoBD());
            ApreensaoController apreensaoController = new ApreensaoController(apreensaoRepositorio);
            apreensaoController.Change(apreensaoToSave.Descricao_Apreensao, apreensaoToSave.Data_Apreencao, apreensaoToSave.N�_Documento);
            DataRow tabelaEncontrada = apreensaoController.Find(apreensaoToSave.N�_Documento).Rows[0];

            //Assert
            string resultdescricao = tabelaEncontrada["Descricao_Apreensao"].ToString();
            Assert.Equal(apreensaoToSave.Descricao_Apreensao, resultdescricao);
        }

        [Fact]
        [Trait("Apreens�o", "metodo delete")]
        public void Delete_DeveEliminar_UmaLinhaNaBD()
        {
            // Arrange
            var apreensaoToSave = new Apreensao
            {
                Descricao_Apreensao = "Alterado",
                Data_Apreencao = "2000-04-04",
                N�_Documento = "3LA",
            };
            //Act
            // Inicializar conex�o  & executar opera��o
            var apreensaoRepositorio = new ApreensaoRepositorio(DBcontexto.CaminhoBD());
            ApreensaoController apreensaoController = new ApreensaoController(apreensaoRepositorio);
            apreensaoController.Delete(apreensaoToSave.N�_Documento);
            int NumeroDeTabelas_Encontradas = apreensaoController.Find(apreensaoToSave.N�_Documento).Rows.Count;

            //Assert
            // string resultadoId = tabelaEncontrada["Id_Apreensao"].ToString();
            Assert.True(NumeroDeTabelas_Encontradas == 0);
        }

    }
}