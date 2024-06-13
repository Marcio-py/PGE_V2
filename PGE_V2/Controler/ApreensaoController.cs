using PGE_V2.Dados;
using PGE_V2.Interface;
using PGE_V2.Modelos;
using PGE_V2.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGE_V2.Controler
{
    public class ApreensaoController
    {
        private readonly IApreensaoRepositorio _apreensaoRepositorio;
        private readonly CDUApreensao _cduApreensao;

        public ApreensaoController(IApreensaoRepositorio apreensaoRepositorio)
        {
            _apreensaoRepositorio = apreensaoRepositorio;
        }

        public void Find(string Nº_Documento)
        {
            _apreensaoRepositorio.BuscarPorId_RetornaUmaLinha(Nº_Documento);
        }

        public async void Create(string descricao, string Data_Apreencao, string Nº_Documento, int Id_Login)
        {
            var apreensaoToSave = new Apreensao
            {
                Descricao_Apreensao = descricao,
                Data_Apreencao = Data_Apreencao,
                Nº_Documento = Nº_Documento,
                Id_Login = Id_Login
            };

            _apreensaoRepositorio.Add(apreensaoToSave);
        }

        public async void Change(string descricao, string Data_Apreencao, string Nº_Documento)
        {

            var apreensaoToSave = new Apreensao
            {
                Descricao_Apreensao = descricao,
                Data_Apreencao = Data_Apreencao,
                Nº_Documento = Nº_Documento,
            };

            _apreensaoRepositorio.Update(apreensaoToSave);
        }

        public void Delete(string Nº_Documento)
        {
            var apreensaoToSave = new Apreensao
            {
                Nº_Documento = Nº_Documento,
            };

            _apreensaoRepositorio.Delete(apreensaoToSave);
        }

    }
}
