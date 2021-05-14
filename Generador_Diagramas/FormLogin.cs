using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Generador_Diagramas.Formbases;
using Capa_Negocio;
using Capa_Entidades;
using MySql.Data.MySqlClient;
using System.Net;

namespace Generador_Diagramas
{
    public partial class FormLogin : InvocadoBase
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); //mover form
        }
        N_Login neg = new N_Login();
        public static int ID_Usuario; // guardar el id del usuario
        void log() //proceso de logue
        {
            E_Login entities = new E_Login();
            entities.Correo_Usuario = txtusuario.Text.ToLower();
            entities.Pass = InvocadoBase.sha256(TXTPASS.Text);
            DataTable dt = neg.IniciarSession(entities);
            if(dt.Rows.Count == 0)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", "EL USUARIO O CONTRASEÑA SON INCORECTOS, REVISE POR FAVOR !");
                TXTPASS.Clear(); TXTPASS.Focus();
            }
            else{
                if (Convert.ToInt32(dt.Rows[0]["Estado_Usuario"]) == 1)
                {
                    FormCompletado.Mensaje("CREDENCIALES AUTORIZADAS", "BIENVENIDO : " + entities.Correo_Usuario.ToUpper());
                    ID_Usuario = Convert.ToInt32(dt.Rows[0]["ID_Usuario"].ToString().Trim());
                    Formprincipal form = new Formprincipal();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    DialogResult RESILT = new DialogResult();
                    FormPregunta f = new FormPregunta("QUIERES VOLVER CON NOSOTROS EHH", "HEMOS DETECTADO QUE TU CUENTA ESTA DESACTIVADA QUERES ACTIVARLA DE NUEVO??");
                    RESILT = f.ShowDialog();
                    if (RESILT == DialogResult.OK)
                    {
                        neg.ActivarCuenta(entities.Correo_Usuario, true);
                        FormCompletado.Mensaje("TAREA REALIZADA", "SE CAMBIO RESTABLECIO LA CUENTA EXITOSAMENTE.");
                    }
                }
            }

        }

        private void btniniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                    log();
            }
            catch (Exception ex)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
            }
        }
        private void TXTPASS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return)) //si se presiona enter se hara lo mimo del login
            {
                try
                {
                    log();
                }
                catch (Exception ex)
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
                }
            }
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
            DialogResult RESILT = new DialogResult();
            FormPregunta f = new FormPregunta("REGISTRARSE", "QUIERE REGISTRAR UN NUEVO USUARIO?");
            RESILT = f.ShowDialog();
            if(RESILT == DialogResult.OK)
            {
                FormRegister fo = new FormRegister();
                fo.ShowDialog();
            }
            
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //nos ayuda a mover el form con mantener click en el panel.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
    }
}
