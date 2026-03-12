using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Clases
{
   
    
        public class Vendedor
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public bool Nuevo { get; set; }
            public Vendedor(int id)
            {
                Nuevo = true;
                var conn = Clases.Datos.Conexion();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Vendedores where id=@id", conn);
                cmd.Parameters.AddWithValue("id", id);
                SqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    //Id=lector.GetInt32(0);
                    //Nombre=lector.GetString(1);

                    Id = int.Parse(lector["Id"].ToString());
                    Nombre = lector["Nombre"].ToString();
                    Nuevo = false;
                }
                conn.Close();

            }

            public void Eliminar()
            {
                var conn = Clases.Datos.Conexion();
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Vendedores where id=@id", conn);
                cmd.Parameters.AddWithValue("id", Id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            public string Guardar()
            {
                string res = "OK";
                if (Nuevo)
                {
                    var sig = Clases.Datos.SiguienteVend();
                    if (sig > Id)
                    {
                        res = sig.ToString();
                        Id = sig;
                    }
                }
                SqlCommand cmd;
                var conn = Clases.Datos.Conexion();
                conn.Open();
                if (Nuevo)
                    cmd = new SqlCommand("Insert into Vendedores values(@id,@Nombre)", conn);
                else
                    cmd = new SqlCommand("Update Vendedores set Nombre=@Nombre where Id=@Id", conn);

                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.ExecuteNonQuery();
                conn.Close();

                return res;
            }
        }
}
