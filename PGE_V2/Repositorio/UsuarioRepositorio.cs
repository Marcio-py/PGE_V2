using PGE_V2.Dados;
using PGE_V2.Interface;
using PGE_V2.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGE_V2.Repositorio
{
    public class UsuarioRepositorio : UsuarioInterface
    {
        // campo para pegar a conexão com a bd
        private readonly DBcontexto _contexto;
       public UsuarioRepositorio(DBcontexto contexto)
        {
            _contexto = contexto;
        }
        // campos para fazer o crud
        public bool Add()
        {
            throw new NotImplementedException();
        }

        public bool Add(Civil dadosPessoais)
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool Delete(Civil dadosPessoais)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Civil>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public bool Update(Civil dadosPessoais)
        {
            throw new NotImplementedException();
        }
    }
}
