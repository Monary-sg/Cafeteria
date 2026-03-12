using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Clases
{
    public class Articulo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int TamaMl { get; set; }
        public int Departamento { get; set; }
        public double Precio { get; set; }
        public int TasaIva { get; set; }
        public string Activo { get; set; }

        public bool Nuevo { get; set; }
        public Articulo(string codigo)
        {
            Nuevo = true;
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from articulos where Codigo=@codigo", conn);
            cmd.Parameters.AddWithValue("codigo", codigo);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                //Codigo=lector.GetString(0);
                //Nombre=lector.GetString(1);
                //Departamento = lector.GetInt32(2);
                //Precio = lector.GetDouble(3);
                //TasaIva = lector.GetInt32(4);
                //Activo = lector.GetString(5);

                Codigo = lector["Codigo"].ToString();
                Nombre = lector["Nombre"].ToString();
                TamaMl = int.Parse(lector["TamaMl"].ToString());
                Departamento = int.Parse(lector["Departamento"].ToString());
                Precio = double.Parse(lector["Precio"].ToString());
                TasaIva = int.Parse(lector["TasaIva"].ToString());
                Activo = lector["Activo"].ToString();
                Nuevo = false;
            }
            conn.Close();

        }

        public void Eliminar()
        {
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Articulos where Codigo=@codigo", conn);
            cmd.Parameters.AddWithValue("codigo", Codigo);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public string Guardar()
        {
            string res = "OK";
            SqlCommand cmd;
            var conn = Clases.Datos.Conexion();
            conn.Open();
            if (Nuevo)
                cmd = new SqlCommand("Insert into Articulos values(@codigo,@Nombre,@departamento,@Precio,@TamaMl,@tasaIva,@Activo)", conn);
            else
                cmd = new SqlCommand("Update Articulos set Nombre=@Nombre,Departamento=@departamento,Precio=@Precio,TamaMl=@TamaMl,TasaIva=@tasaIva,Activo=@activo where Codigo=@codigo", conn);

            cmd.Parameters.AddWithValue("@codigo", Codigo);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@departamento", Departamento);
            cmd.Parameters.AddWithValue("@Precio", Precio);
            cmd.Parameters.AddWithValue("@TamaMl", TamaMl);
            cmd.Parameters.AddWithValue("@TasaIva", TasaIva);
            cmd.Parameters.AddWithValue("@Activo", Activo);
            cmd.ExecuteNonQuery();
            conn.Close();

            return res;
        }
        static public string Existe(string codigo)
        {
            string res = "Error";
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from articulos where Codigo=@codigo", conn);
            cmd.Parameters.AddWithValue("codigo", codigo);
            SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                res = lector["Nombre"].ToString();
            }
            conn.Close();
            return res;
        }

    }
}
