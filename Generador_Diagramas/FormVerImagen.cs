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
using Capa_Entidades;
using Capa_Negocio;
using System.Runtime.InteropServices;

namespace Generador_Diagramas
{
    public partial class FormVerImagen : InvocadoBase
    {
        public bool editar = false;
        public FormVerImagen()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVerImagen_Load(object sender, EventArgs e)
        {
            try
            {
                if(editar == false)
                {
                    lbinactivo.Visible = true;
                    btneditar.Visible = false;
                }
                else if(editar == true)
                {
                    lbinactivo.Visible = false;
                    btneditar.Visible = true;
                }
            }
            catch (Exception EQ)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", EQ.Message);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e) //guarda un png si lo desea el user
        {
            try
            {
                savedialog.DefaultExt = "png";
                savedialog.Filter = "PNG files|*.png";
                if(savedialog.ShowDialog() == DialogResult.OK)
                {
                    Image img = pcitureImage.Image;
                    img.Save(savedialog.FileName);
                    FormCompletado.Mensaje("ACTIVIDAD REALIZADA", "EL ARCHIVO SE EXPORTO CORRECTAMENTE...");
                    img.Dispose();
                }

            }
            catch (Exception EQ)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", EQ.Message);
            }
        }

        // metodo para mover el form en el evento mousedown de un panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void copiarTextoToolStripMenuItem_Click(object sender, EventArgs e) //sirver para copiar al momento del click en un label
        {
            ToolStripItem menuItem = sender as ToolStripItem;

            if (menuItem != null)
            {
                ContextMenuStrip menu = menuItem.Owner as ContextMenuStrip;

                if (menu != null)
                {
                    Control control = menu.SourceControl; //obtiene el control donde se mostrara el menu
                    Clipboard.SetText(((Label)control).Text); //copia
                    FormCompletado.Mensaje("COMPLETADO", "SE COPIO CORRECTAMENTE!");
                }
            }
        }

        private void lbruta_Click(object sender,EventArgs e)
        {
        }

        private void lbruta_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(lbruta, e.Location); //mostrando menu
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FormEditDiagram f = new FormEditDiagram();
            f.txtnombre.Text = lbnombre.Text;
            f.ShowDialog(); //si se usa .HIDE nos da un error a la hora de editarlo pero con ShowDialog se soluciono...
            this.Hide();
        }
    }
}
