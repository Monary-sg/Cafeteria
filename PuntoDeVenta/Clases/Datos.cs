using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;



namespace PuntoDeVenta.Clases
{
    public class Datos
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=PuntoDeVenta;Integrated Security=yes");
        //SqlConnection conn = new SqlConnection(@"Server=(local)\SQLEXPRESS;Initial Catalog=PuntoDeVenta;Integrated Security=yes");
        //SqlConnection conn = new SqlConnection(@"Server=(local)\SQLEXPRESS;Database=PuntoDeVenta;user=SYSadmin; password=123");
        static SqlConnection conn = new SqlConnection(@"Server=(local)\SQLEXPRESS;Database=PVenta;Integrated Security=yes");
        static public KeyPressEventArgs enter = new KeyPressEventArgs((char)Keys.Enter);
        static public SqlConnection Conexion()
        {
            return conn;
        }
   
        static public int SiguienteDepa()
        {
            int res;
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select ISNULL(max(Id), 0) + 1 from Departamentos", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            res = int.Parse(dt.Rows[0][0].ToString());
            conn.Close();
            return res;
        }
        static public int SiguienteVend()
        {
            int res;
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select ISNULL(max(Id), 0) + 1 from Vendedores", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            res = int.Parse(dt.Rows[0][0].ToString());
            conn.Close();
            return res;
        }
        static public int SiguienteRenglon(int folio)
        {
            int res;
            var conn = Clases.Datos.Conexion();
            SqlDataAdapter da = new SqlDataAdapter("select ISNULL(max(renglon), 0) + 1 from VentasTemp where folio=@folio", conn);
            da.SelectCommand.Parameters.AddWithValue("@folio", folio);
            DataTable dt = new DataTable();
            da.Fill(dt);
            res = int.Parse(dt.Rows[0][0].ToString());
            return res;
        }
        static public int SiguienteFolio()
        {
            int res;
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select ISNULL(max(Folio), 0) + 1 from Ventas", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            res = int.Parse(dt.Rows[0][0].ToString());
            conn.Close();
            return res;
        }
        static public DataTable Consulta(string elSelect)
        {
            var dt = new DataTable();
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(elSelect, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //static public string Conectar()
        //{
        //    string result = "";
        //    try
        //    {
        //        conn.Open();
        //        result = "OK";
        //    }
        //    catch (Exception ex) 
        //    { 
        //        result = ex.Message;
        //    }
        //    return result;
        //}

        //static public void DesConectar()
        //{
        //    conn.Close();
        //}

        static public void EliminaRenglon(int folio,int renglon)
        {
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from VentasTemp where folio=@folio and renglon=@renglon", conn);
            cmd.Parameters.AddWithValue("@folio", folio);
            cmd.Parameters.AddWithValue("@renglon", renglon);
            cmd.ExecuteNonQuery();
            conn.Close();
            return;
        }

        static public void EliminaVenta(int folio)
        {
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from VentasTemp where folio=@folio", conn);
            cmd.Parameters.AddWithValue("@folio", folio);
            cmd.ExecuteNonQuery();
            conn.Close();
            return;
        }
        static public void GuardaVenta(int folio, int renglon, string codigo, double cantidad, double precio,int tasaIva, int TamaMl)
        {
            double subTotal = 0; double iva = 0; double total = 0;
            total=cantidad*precio;
            subTotal = Math.Round(total / (1 + ((double)tasaIva / 100)),2);
            iva=total-subTotal;
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlCommand cmd;
            if (renglon == 0)
            {
                renglon = SiguienteRenglon(folio);
                cmd = new SqlCommand("Insert into VentasTemp values(@folio,@renglon,@codigo,@cantidad,@precio,@TamaMl,@tasaIva,@subTotal,@iva,@total)", conn);
            }
            else
                cmd = new SqlCommand("Update VentasTemp set Codigo=@codigo,Cantidad=@cantidad,Precio=@precio,TamaMl=@TamaMl,tasaIva=@tasaIva,SubTotal=@subTotal,Iva=@iva,Total=@total where Folio=@folio and Renglon=@renglon", conn);
            cmd.Parameters.AddWithValue("@folio", folio);
            cmd.Parameters.AddWithValue("@renglon", renglon);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@TamaMl", TamaMl);
            cmd.Parameters.AddWithValue("@tasaIva", tasaIva);
            cmd.Parameters.AddWithValue("@subTotal", subTotal);
            cmd.Parameters.AddWithValue("@iva", iva);
            cmd.Parameters.AddWithValue("@Total", total);
            cmd.ExecuteNonQuery();

            conn.Close() ;
        }
        static public DataTable LaVenta(string folio)
        {
            DataTable dt= new DataTable();
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlDataAdapter da=new SqlDataAdapter("Select v.Renglon,v.Codigo,a.Nombre,v.Cantidad,v.Precio,v.TamaMl,v.TasaIva,v.SubTotal,v.Iva,V.Total From VentasTemp as v inner join articulos as a on v.codigo=a.codigo where v.folio=@folio order by Renglon", conn);
            da.SelectCommand.Parameters.AddWithValue("@folio", folio);
            da.Fill(dt);
            conn.Close() ;
            return dt;
        }

        static public DataTable LasVenta(string vendedor,string fecha1,string fecha2)
        {
            DataTable dt = new DataTable();
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select folio,fecha,subTotal,Iva,Total from ventas where vendedor=@vendedor and fecha2 between @fecha1 and @fecha2 order by fecha2,folio", conn);
            da.SelectCommand.Parameters.AddWithValue("@vendedor", vendedor);
            da.SelectCommand.Parameters.AddWithValue("@fecha1", fecha1);
            da.SelectCommand.Parameters.AddWithValue("@fecha2", fecha2);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        static public void GuardaVenta(string folio,string vendedor,DateTime fecha,string sub,string iva,string tot,DataTable dt )
        {
            var conn = Clases.Datos.Conexion();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Ventas(folio,vendedor,fecha,subtotal,iva,total) values(@folio,@vendedor,@fecha,@subtotal,@iva,@total)", conn);
            cmd.Parameters.AddWithValue("@folio", folio);
            cmd.Parameters.AddWithValue("@vendedor", vendedor);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.Parameters.AddWithValue("@subTotal", double.Parse(sub));
            cmd.Parameters.AddWithValue("@iva", double.Parse(iva));
            cmd.Parameters.AddWithValue("@total", double.Parse(tot));
            cmd.ExecuteNonQuery();

            SqlCommand cmdDet = new SqlCommand("Insert into VentasDetalle(folio,renglon,vendedor,fecha,codigo,cantidad,precio,subtotal,iva,total) values(@folio,@renglon,@vendedor,@fecha,@codigo,@cantidad,@precio,@subtotal,@iva,@total)", conn);
            int ren = 1;
            foreach(DataRow r in dt.Rows)
            {               
                cmdDet.Parameters.Clear();
                cmdDet.Parameters.AddWithValue("@folio", folio);
                cmdDet.Parameters.AddWithValue("@renglon", ren);
                cmdDet.Parameters.AddWithValue("@vendedor", vendedor);
                cmdDet.Parameters.AddWithValue("@fecha", fecha);
                cmdDet.Parameters.AddWithValue("@codigo", r["Codigo"].ToString());
                cmdDet.Parameters.AddWithValue("@cantidad", r["Cantidad"].ToString());
                cmdDet.Parameters.AddWithValue("@precio", r["Precio"].ToString());
                cmdDet.Parameters.AddWithValue("@subTotal", r["SubTotal"].ToString());
                cmdDet.Parameters.AddWithValue("@iva", r["Iva"].ToString());
                cmdDet.Parameters.AddWithValue("@total", r["Total"].ToString());
                cmdDet.ExecuteNonQuery();
                ren++;
            }            
            conn.Close();
            EliminaVenta(int.Parse(folio));
        }
       



        static public DataTable Vendedores()
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Vendedores", conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
