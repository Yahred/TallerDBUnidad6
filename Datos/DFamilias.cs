using Biblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Datos
{
    public class DFamilias
    {
        public static List<Familia> GetFamilias()
        {
            List<Familia> familias;
            DataTable table= new DataTable();
            SqlDataReader lector;
          
            try
            {
                SqlCommand comando = new SqlCommand("SELECT FamID, FamNombre FROM Familias", Conexion.Connection);
                comando.CommandType = CommandType.Text;
                lector = comando.ExecuteReader();
                table.Load(lector);
                familias = (from row in table.AsEnumerable()
                            select 
                                new Familia
                                {
                                    ID = row.Field<int>("famid"),
                                    Nombre = row.Field<string>("famnombre")
                                }
                            ).ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return familias;
        }
    }
}
