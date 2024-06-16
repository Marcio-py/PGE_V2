using PGE_V2.Interface;
using PGE_V2.Modelos;
using PGE_V2.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGE_V2.Controler
{
    public class CivilController
    {
        private readonly ICivilRepositorio _civilRepositorio;

        public CivilController(ICivilRepositorio civilRepositorio)
        {
            _civilRepositorio = civilRepositorio;
        }

        public DataTable Find(string Nº_Documento)
        {
            var civilParaBuscar = new Civil
            {
                Nº_BI = Nº_Documento,
            };

            return _civilRepositorio.BuscarPorId(civilParaBuscar);
        }

        public void Create( string Nome, string Filho_de, string E_de,
            string Data_Nascimento, string Genero, int Id_Endereco,string Nº_Documento)
        {
            var civilParaSalvar = new Civil
            {
                Nome_Completo = Nome,
                Filho_de = Filho_de,
                E_de = E_de,
                Data_Nasc = Data_Nascimento,
                Genero = Genero,
                Id_Endereco = Id_Endereco,
                Nº_BI = Nº_Documento
            };
        _civilRepositorio.Add(civilParaSalvar);
        }

        public void Change(string Nome, string Filho_de, string E_de,
    string Data_Nascimento, string Genero, int Id_Endereco, string Nº_Documento)
        {
            var civilParaSalvar = new Civil
            {
                Nome_Completo = Nome,
                Filho_de = Filho_de,
                E_de = E_de,
                Data_Nasc = Data_Nascimento,
                Genero = Genero,
                Id_Endereco = Id_Endereco,
                Nº_BI = Nº_Documento
            };
            _civilRepositorio.Update(civilParaSalvar);
        }
    }
}
