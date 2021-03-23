using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_Diagramas.Formbases
{
    public partial class FormPregunta : InvocadoBase
    {
        public FormPregunta(string titulo, string mensaje)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //redondear form
            LBTITULO.Text = titulo;
            LBCONTENIDO.Text = mensaje;
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private extern static IntPtr CreateRoundRectRgn(
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthElipse,
               int nHeightElipse
           );
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btncacelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
