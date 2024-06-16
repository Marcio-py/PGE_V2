using PGE_V2.Controler;
using PGE_V2.Dados;
using PGE_V2.Modelos;
using PGE_V2.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class CivilTeste
    {
        [Fact]
        [Trait("Civil", "Create update read")]
        public void Create_DeveAdicionar_UmaLinhaNaBD()
        {
            // Arrange
            var civilParaSalvar = new Civil
            {
                Nome_Completo = "CIVIL",
                Filho_de = "CIVIL",
                E_de = "CIVIL",
                Data_Nasc = "2000/01/01",
                Genero = "Masculino",
                Id_Endereco = 1,
                Nº_BI = "123"
            };

            // Inicializar conexão
            var civilRepositorio = new CivilRepositorio(DBcontexto.CaminhoBD());
            // executar operação
            CivilController civilController = new CivilController(civilRepositorio);
            int documentosRepetidos = civilController.Find("123").Rows.Count;
            if (documentosRepetidos < 1)
            {
                civilController.Create(
                    civilParaSalvar.Nome_Completo,
                    civilParaSalvar.Filho_de,
                    civilParaSalvar.E_de,
                    civilParaSalvar.Data_Nasc,
                    civilParaSalvar.Genero, 1,
                    civilParaSalvar.Nº_BI);
            }

            // Act
            // Se houver numeros de documentos repetidos cancela a operação
            documentosRepetidos = civilController.Find(civilParaSalvar.Nº_BI).Rows.Count;
            // Assert (Verificar se a informação foi adicionada)
            Assert.Equal(1, documentosRepetidos);
        }

        [Fact]
        [Trait("Civil", "Create update read")]
        public void Change_DeveAlterar_DescricaoLinhaSelecionada()
        {
            // Arrange
            var civilParaAtualizar= new Civil
            {
                Nome_Completo = "Amostra alteração",
                Filho_de = "CIVIL",
                E_de = "CIVIL",
                Data_Nasc = "2000/04/02",
                Genero = "Masculino",
                Id_Endereco = 1,
                Nº_BI = "123"
            };
            //Act
            var civilRepositorio = new CivilRepositorio(DBcontexto.CaminhoBD());
            CivilController civilController = new CivilController(civilRepositorio);
            civilController.Change(civilParaAtualizar.Nome_Completo,
                    civilParaAtualizar.Filho_de,
                    civilParaAtualizar.E_de,
                    civilParaAtualizar.Data_Nasc,
                    civilParaAtualizar.Genero, 1,
                    civilParaAtualizar.Nº_BI);
            // Assert
            DataRow tabelaEncontrada = civilController.Find(civilParaAtualizar.Nº_BI).Rows[0];
            string resultdescricao = tabelaEncontrada["Nome_Completo"].ToString();
            Assert.Contains(civilParaAtualizar.Nome_Completo, resultdescricao);
        }

        [Fact]
        [Trait("Civil", "Create update read")]
        public void ProcuraElementoPorID_DeveRetorna_ValorDaLinhaSelecionada()
        {
            // Arrange
            var civilParaBuscar = new Civil
            {
                Nome_Completo = "Amostra alteração",
                Filho_de = "CIVIL",
                E_de = "CIVIL",
                Data_Nasc = "2000/04/02",
                Genero = "Masculino",
                Id_Endereco = 1,
                Nº_BI = "123"
            };
            //Act

            // Inicializar conexão  & executar operação
            var civilRepositorio = new CivilRepositorio(DBcontexto.CaminhoBD());
            CivilController civilController = new CivilController(civilRepositorio);
            DataRow tabelaEncontrada = civilController.Find(civilParaBuscar.Nº_BI).Rows[0];

            //Assert
            string resultdescricao = tabelaEncontrada["Nome_Completo"].ToString();
            Assert.Equal(civilParaBuscar.Nome_Completo, resultdescricao);
        }

    }
}
