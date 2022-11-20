using Biblioteca.Datos;
using Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocios
{
    public class NArticulos
    {
        public int RegistrarArticulo(Articulo articulo)
        {
            DArticulo articuloD = new DArticulo();
            return articuloD.RegistrarArticulo(articulo);
        }

        public DataTable ObtenerGridArticulos(Articulo filtro) 
        {
            DArticulo articuloD = new DArticulo();
            DataTable grid = articuloD.ObtenerGridArticulos(filtro);
            return grid;
        }

        public Articulo ObtenerArticuloPorID(int id)
        {
            DArticulo articuloD = new DArticulo();
            return articuloD.ObtenerArticuloPorID(id);
        }

        public bool EliminarArticulo(int id)
        {
            DArticulo articuloD = new DArticulo();
            return articuloD.EliminarArticulo(id);
        }
    }

}
