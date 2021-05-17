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
    public partial class FormSetting : InvocadoBase
    {
        public FormSetting()
        {
            InitializeComponent();
            defaultview();
            MostrarDatos();
        }
        void defaultview() //vista por defecto
        {
            txtusuario.Enabled = false;
            txtfecha.Enabled = false;
            txtestado.Enabled = false;
        }
        N_Login neg = new N_Login();
        public static DataSet ds;
        void MostrarDatos() //cargamos datos por usuario
        {
            List<E_Login> datos = neg.VerDatosCuenta(FormLogin.ID_Usuario);
            ds = InvocadoBase.ConvertirADatasetLista<E_Login>(datos);
            txtusuario.Text = ds.Tables[0].Rows[0]["Correo_Usuario"].ToString().Trim();
            txtfecha.Text  = ds.Tables[0].Rows[0]["Fecha_Ingreso"].ToString().Trim();
            txtestado.Text = "ACTIVO";
        }
        private void btnaceptar_Click(object sender, EventArgs e) //btndesactivar
        {
            FormPregunta fo = new FormPregunta("ESTA SEGURO ?", "SI USTED DA CLICK EN ACEPTAR SE DESACTIVARA SU CUENTA PARA EL USO DE NUESTRO SISTEMA ");
            DialogResult RES = new DialogResult();
            RES = fo.ShowDialog();
            if(RES == DialogResult.OK)
            {
                FormConfirmDesactivar f = new FormConfirmDesactivar();
                f.ShowDialog();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarcontra_Click(object sender, EventArgs e)
        {
            FormCambioPassword f = new FormCambioPassword();
            f.ShowDialog();
        }

        private void btnhistorial_Click(object sender, EventArgs e)
        {
            FormHistorial f = new FormHistorial();
            f.ShowDialog();
        }
    }
}
