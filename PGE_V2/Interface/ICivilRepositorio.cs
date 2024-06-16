using PGE_V2.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGE_V2.Interface
{
    public interface ICivilRepositorio
    {
        void Add(Civil civil);

        void Update(Civil civil);

        void Delete(Civil civil);

        DataTable BuscarPorId(Civil civil);
    }
}
