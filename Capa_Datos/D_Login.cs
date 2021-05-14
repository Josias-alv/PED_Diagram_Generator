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
    public class D_Login
    {
        MySqlConnection conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString); //cadena en app.config
        //FORM LOGIN
        //ejecutamos el procedimientos almacenados de la base para el programa
        public DataTable IniciarSesion(E_Login sender)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_Login", conexion); //PASAMOS NOBRE DEL STOREPROCEDURE Y LA CONEXION
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("Usuario", sender.Correo_Usuario); //PARAMETROS
                cmd.Parameters.AddWithValue("Passwords", sender.Pass);
                MySqlDataAdapter adaptarinfo = new MySqlDataAdapter(cmd);
                adaptarinfo.Fill(dt);
            }
            catch (MySqlException ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally //ASEGURANDONOS QUE SIEMPRE SE CIERRE LA CONEXION
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return dt;
        }
        public void CREARUSER(E_Login SENDER)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_CREARUSER", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("Usuario", SENDER.Correo_Usuario);
                cmd.Parameters.AddWithValue("Passwords", SENDER.Pass);
                cmd.Parameters.AddWithValue("ESTADOUSER", SENDER.Estado);
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
        public void DESACTIVARActivar(int IDUSER , bool ESTADO)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_DESACTIVAR", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("IDUSER", IDUSER);
                cmd.Parameters.AddWithValue("ESTADO", ESTADO);
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
        public List<E_Login> verdatos(int iduser) //lenando una lista para ver datos del usuario
        {
            List<E_Login> lista = new List<E_Login>();
            MySqlDataReader leerrows = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_VERDATOS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("IDUSER", iduser);
                leerrows = cmd.ExecuteReader();
                while (leerrows.Read()) //RELLENAMOS LOS DATOS DEL MYSQL EN UNA LISTA
                {
                    lista.Add(new E_Login()
                    {
                        ID_Usuario = leerrows.GetInt32(0),
                        Correo_Usuario = leerrows.GetString(1),
                        Pass = leerrows.GetString(2),
                        Fecha_Ingreso = leerrows.GetDateTime(3),
                        Estado = leerrows.GetBoolean(4)
                    });
                }
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
                    leerrows.Close();
                }
            }
            return lista;
        }
        public void editarcontrasena(E_Login sender)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_CAMBIARPASS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("IDUSER", sender.ID_Usuario);
                cmd.Parameters.AddWithValue("PASS", sender.Pass);
                cmd.ExecuteNonQuery();
                conexion.Close();
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
           
        }
        public void EDITARESTADOuser(string CORREOUSER, bool estado)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SP_ACTIVARCUENTA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                cmd.Parameters.AddWithValue("CORREOUSER", CORREOUSER);
                cmd.Parameters.AddWithValue("ESTADO", estado);
                cmd.ExecuteNonQuery();
                conexion.Close();
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
        }
    }
}
