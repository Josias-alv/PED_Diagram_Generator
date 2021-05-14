using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Generador_Diagramas.Formbases;
using Capa_Entidades;
using System.Runtime.InteropServices;

namespace Generador_Diagramas
{
    public partial class FormCambioPassword : InvocadoBase
    {
        public FormCambioPassword()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        N_Login neg = new N_Login(); // obteniendo metodos del login
        private void btnCambiarcontra_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtantiguacontra.Text) || string.IsNullOrEmpty(txtnuevacontra.Text) || string.IsNullOrEmpty(txtnuvacontraconfirm.Text))
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", "NO SE PUEDEN INGRESAR DATOS NULOS O VACIOS !.");
                }
                else
                {
                    if (sha256(txtantiguacontra.Text) != FormSetting.ds.Tables[0].Rows[0]["Pass"].ToString().Trim()) //comparando con contrasena antigua
                    {
                        FormError.Mensaje("HA OCURRIDO UN ERROR", "ESA NO ES SU CONTRASEÑA ANTIGUA POR FAVOR VERIFIQUE !.");
                    }
                    else
                    {
                        if (txtnuevacontra.Text != txtnuvacontraconfirm.Text)
                        {
                            FormError.Mensaje("HA OCURRIDO UN ERROR", "EL CAMPO (NUEVA CONTRASEÑA) TIENE QUE SER IGUAL AL CAMPO DE (CONFIRMAR NUEVA CONTRASEÑA) POR FAVOR VERIFIQUE !.");
                        }
                        else
                        {
                            E_Login entitites = new E_Login();
                            entitites.ID_Usuario = FormLogin.ID_Usuario;
                            entitites.Pass = sha256(txtnuvacontraconfirm.Text); //cambio de contrasena ya con sha256
                            neg.editcontra(entitites);
                            FormCompletado.Mensaje("TAREA REALIZADA", "SE CAMBIO SU CONTRASEÑA EXITOSAMENTE.");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", ex.Message);
            }
        }











        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] 
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam); //metodo para mover el form

        private void panel1_MouseDown(object sender, MouseEventArgs e) //para poder mover el form
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
