using Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Datos
{
    public class DArticulo
    {
        public int RegistrarArticulo(Articulo articulo)
        {
            try
            {
                SqlCommand comando = new SqlCommand("sp_Articulos", Conexion.Connection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ArtNombre", DbType.String).Value = articulo.Nombre;
                comando.Parameters.AddWithValue("@ArtDescripcion", DbType.String).Value = articulo.Descripcion;
                comando.Parameters.AddWithValue("@ArtPrecio", DbType.Decimal).Value = articulo.Precio;
                comando.Parameters.AddWithValue("@FamID", DbType.Int32).Value = articulo.Familia.ID;
                comando.Parameters.AddWithValue("@ArtID", DbType.Int32).Value = articulo.ID;
                if (articulo.ID == 0)
                    comando.Parameters["@ArtID"].Direction = ParameterDirection.Output;

                comando.ExecuteNonQuery();

                return Convert.ToInt32(comando.Parameters["@ArtID"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public DataTable ObtenerGridArticulos(Articulo filtros)
        {
            DataTable table = new DataTable();
            SqlDataReader lector;

            try
            {
                SqlCommand comando = new SqlCommand("sp_GridArticulos", Conexion.Connection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ID", filtros.ID);
                comando.Parameters.AddWithValue("@Nombre", filtros.Nombre);
                comando.Parameters.AddWithValue("@Precio", filtros.Precio);
                comando.Parameters.AddWithValue("@FamID", filtros.Familia.ID);

                lector = comando.ExecuteReader();
                table.Load(lector);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return table;
        }

        public Articulo ObtenerArticuloPorID(int ID)
        {
            Articulo articulo;
            DataTable table = new DataTable();
            SqlDataReader lector;

            try
            {
                SqlCommand comando = new SqlCommand("sp_ObtenerArticuloPorID", Conexion.Connection);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ArtID", ID);
                lector = comando.ExecuteReader();
                table.Load(lector);
                articulo = (from row in table.AsEnumerable()
                            select
                                new Articulo
                                {
                                    ID = row.Field<int>("ID"),
                                    Nombre = row.Field<string>("Nombre"),
                                    Descripcion = row.Field<string>("Descripcion"),
                                    Precio = row.Field<decimal>("Precio"),
                                    Familia = new Familia
                                    {
                                        ID = row.Field<int>("FamiliaID"),
                                        Nombre = row.Field<string>("Familia")
                                    }
                                }
                            ).ToList()[0];

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return articulo;
        }

        public bool EliminarArticulo(int id)
        {
            try
            {
                SqlCommand comando = new SqlCommand($"DELETE FROM Articulos WHERE ArtID = {id}", Conexion.Connection);
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
    }
}
