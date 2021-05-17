using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using Capa_Entidades;


namespace Capa_Datos
{
    public class D_History
    {
        MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString); //cadena en app.config

        //procedimientos traidos desde la base de datos
        //se trabajo mas que todo con procedimientos almacenados
        public DataTable vertodos(int iduser)
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_TODOSDIAGRAMS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("IDUSER", iduser); //agregamos valor al parametro del STOREPROCEDURE
                MySqlDataAdapter adaptarinfo = new MySqlDataAdapter(cmd);
                adaptarinfo.Fill(dt);
            }
            catch (Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return dt;
        }
        public DataTable verActivosODesactivados(int iduser, bool ActOdeact)
        {
            DataTable dt = new DataTable();
            MySqlDataReader leerfilas = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_VERDIAGRAM", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("IDUSER", iduser);
                cmd.Parameters.AddWithValue("STATUSDES", ActOdeact);
                leerfilas = cmd.ExecuteReader();
                dt.Load(leerfilas);
            }
            catch (Exception ex)
            {
                // System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    leerfilas.Close();
                }
            }
             return dt;
        }
        public void CrearDiagrama(E_Diagramas SENDER)
        {
            try
            {
                
                MySqlCommand cmd = new MySqlCommand("SP_CREARDIAGRAM", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("IDUSER", SENDER.Id_Usuario);
                cmd.Parameters.AddWithValue("NOMBRE", SENDER.Nombre);
                cmd.Parameters.AddWithValue("ARCHIVOJSON", SENDER.archivoJson);
                cmd.Parameters.AddWithValue("ARCHIVOPNG", SENDER.ArchivoPNG);
                cmd.Parameters.AddWithValue("RUTA", SENDER.Ruta);
                cmd.Parameters.AddWithValue("FECHA", SENDER.Fecha);
                cmd.Parameters.AddWithValue("STATUSACT", SENDER.Status);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        public byte[] TraerIMGDiagram(int iddiagram)
        {
            byte[] byteimg = null;
            try
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = "SELECT ArchivoPNG FROM Diagramas_Generados WHERE ID_Diagrama=@idDiagram";
                cmd.Parameters.AddWithValue("@idDiagram", iddiagram);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count == 1)
                {
                   byteimg = (byte[])dt.Rows[0]["ArchivoPNG"]; // convirtiendo a un byte
                }
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return byteimg;
        }
        public void ACTUALIZARESTADO(int idiagram, bool status)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_DEACTOACTDIAGRAM", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("IDIAGRAM", idiagram);
                cmd.Parameters.AddWithValue("STATUSDES", status);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void EditarDiagrama(E_Diagramas SENDER)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand("SP_EDITARDIAGRAMA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("IDDIGRAM", SENDER.Id_Diagrama);
                cmd.Parameters.AddWithValue("NOMBRE", SENDER.Nombre);
                cmd.Parameters.AddWithValue("ARCHIVOJSON", SENDER.archivoJson);
                cmd.Parameters.AddWithValue("ARCHIVOPNG", SENDER.ArchivoPNG);
                cmd.Parameters.AddWithValue("FECHAEDICION", SENDER.FechaEdicion);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        public void EditarDiagramaConRuta(E_Diagramas SENDER)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_EDITARDIAGRAMACONRUTA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("IDDIGRAM", SENDER.Id_Diagrama);
                cmd.Parameters.AddWithValue("NOMBRE", SENDER.Nombre);
                cmd.Parameters.AddWithValue("ARCHIVOJSON", SENDER.archivoJson);
                cmd.Parameters.AddWithValue("ARCHIVOPNG", SENDER.ArchivoPNG);
                cmd.Parameters.AddWithValue("RUTA", SENDER.Ruta);
                cmd.Parameters.AddWithValue("FECHAEDICION", SENDER.FechaEdicion);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
