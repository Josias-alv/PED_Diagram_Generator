using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_Diagramas.Formbases
{
    public partial class Formbase : Form //FORM BASE PARA PANEL PRINCIPAL QUE ES EL DE DIAGRAMAR
    {
        public Formbase()
        {
            InitializeComponent();
        }

        private void Formbase_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
