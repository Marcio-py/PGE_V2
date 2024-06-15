using PGE_V2.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGE_V2.Interface
{
    public interface IApreensaoRepositorio
    {
        void Add(Apreensao apreensao);

        void Update(Apreensao apreensao);

        void Delete(Apreensao apreensao);

        DataTable BuscarPorId(Apreensao apreensao);
    }
}
