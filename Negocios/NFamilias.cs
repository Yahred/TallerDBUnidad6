using Biblioteca.Datos;
using Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocios
{
    public class NFamilias
    {
        public NFamilias() { }

        public List<Familia> getFamilias()
        {
            try
            {
                return DFamilias.GetFamilias();
            }catch(Exception ex)
            {
                return null;
            }
        }

    }
}
