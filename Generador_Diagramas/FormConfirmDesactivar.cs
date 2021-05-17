using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generador_Diagramas.Formbases;
using Capa_Negocio;
using Capa_Entidades;
namespace Generador_Diagramas
{
    public partial class FormConfirmDesactivar : InvocadoBase
    {
        public FormConfirmDesactivar()
        {
            InitializeComponent();
            txtnuevacontra.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        N_Login neg = new N_Login();
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnuevacontra.Text))
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", "NO SE PUEDEN INGRESAR DATOS NULOS O VACIOS !.");
                txtnuevacontra.Clear();
                txtnuevacontra.Focus();
            }
            else
            {
                if(sha256(txtnuevacontra.Text) != FormSetting.ds.Tables[0].Rows[0]["Pass"].ToString().Trim())
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", "ESA NO ES SU CONTRASEÑA POR FAVOR VERIFIQUE !.");
                    txtnuevacontra.Clear();
                    txtnuevacontra.Focus();
                }
                else
                {
                    neg.Desactivar_Activar_Usuario(FormLogin.ID_Usuario, false); //desactivando el usuario
                    FormCompletado.Mensaje("TAREA COMPLETADA", "SE DESACTIVO SU CUENTA CORRECTAMENTE ESPERAMOS QUE VUELVA PRONTO A DIAGRAMAR CON NOSOTROS!!...");
                    Application.Restart(); //reinicia la app
                }
            }
        }
    }
}
