using PGE_V2.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGE_V2.Interface
{
    internal interface UsuarioInterface
    {
        Task<IEnumerable<Civil>> GetAllUsers();
        //Task<AppUser> GetUserById(string id);
        bool Add(Civil dadosPessoais);
        bool Update(Civil dadosPessoais);
        bool Delete(Civil dadosPessoais);
        //bool Save();
    }
}
