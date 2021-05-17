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
    public partial class FormHistorial : InvocadoBase
    {
        public FormHistorial()
        {
            try
            {
                InitializeComponent();
                //MostrarTodos(FormLogin.ID_Usuario);
                MostrarTodos(FormLogin.ID_Usuario);
                MostrarACT(FormLogin.ID_Usuario);
                MostrarDeact(FormLogin.ID_Usuario);
            }
            catch (Exception EQ)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", EQ.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        N_History neg = new N_History();
        //quitando elementos que no son necesario verlos
        void accionestabla() 
        {
            GRIDDIAGRAMALL.Columns["ID_Diagrama"].Visible = false;
            GRIDDIAGRAMALL.Columns["ArchivoPNG"].Visible = false;
            GRIDDIAGRAMALL.Columns["ArchivoJson"].Visible = false;
            GRIDDIAGRAMALL.Columns["Status_Activo"].Visible = false;
            GRIDDIAGRAMALL.Columns["VER"].DisplayIndex = 8;
            GRIDDIAGRAMALL.ClearSelection();
        }
        void accionestablaact()
        {
            GRID_ACTIVO.Columns["ID_Diagrama"].Visible = false;
            GRID_ACTIVO.Columns["ArchivoPNG"].Visible = false;
            GRID_ACTIVO.Columns["ArchivoJson"].Visible = false;
            GRID_ACTIVO.Columns["Status_Activo"].Visible = false;
            GRID_ACTIVO.Columns["VERACT"].DisplayIndex =9;
            GRID_ACTIVO.Columns["DESACTIVAR"].DisplayIndex = 9;
            GRID_ACTIVO.ClearSelection();
        }
        void accionestabladeact()
        {
            Grid_Desactivado.Columns["ID_Diagrama"].Visible = false;
            Grid_Desactivado.Columns["ArchivoPNG"].Visible = false;
            Grid_Desactivado.Columns["ArchivoJson"].Visible = false;
            Grid_Desactivado.Columns["Status_Activo"].Visible = false;
            Grid_Desactivado.Columns["VERDEACT"].DisplayIndex = 9;
            Grid_Desactivado.Columns["ACTIVAR"].DisplayIndex = 9;
        }
        //cargando datos a la s GRID
        void MostrarTodos(int iduser)
        {
            GRIDDIAGRAMALL.DataSource = null;
            GRIDDIAGRAMALL.Refresh();
            GRIDDIAGRAMALL.Update();
            GRIDDIAGRAMALL.DataSource = neg.VerDiagramasTodos(iduser);
            accionestabla();
        }
        void MostrarACT(int iduser)
        {
            GRID_ACTIVO.DataSource = null;
            GRID_ACTIVO.Refresh();
            GRID_ACTIVO.Update();
            GRID_ACTIVO.DataSource = neg.VerActODeactDiagrams(iduser,true);
            accionestablaact();
        }
        void MostrarDeact(int iduser)
        {
            Grid_Desactivado.DataSource = null;
            Grid_Desactivado.Refresh();
            Grid_Desactivado.Update();
            Grid_Desactivado.DataSource = neg.VerActODeactDiagrams(iduser, false);
            accionestabladeact();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // metodo para mover el form en el evento mousedown de un panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);

        private void GRIDDIAGRAMALL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GRIDDIAGRAMALL.Rows[e.RowIndex].Cells["VER"].Selected) //SI SELECCIONA LA COLUMNA VER
                {
                    FormVerImagen F = new FormVerImagen();
                    FormEditDiagram.ID_Diagrama = Convert.ToInt32(GRIDDIAGRAMALL.Rows[e.RowIndex].Cells["ID_Diagrama"].Value);//id del diagrama
                    FormEditDiagram.DiagramaEditar = GRIDDIAGRAMALL.Rows[e.RowIndex].Cells["ArchivoJson"].Value.ToString();
                    F.editar = Convert.ToBoolean(GRIDDIAGRAMALL.Rows[e.RowIndex].Cells["Status_Activo"].Value.ToString());
                    F.lbnombre.Text = GRIDDIAGRAMALL.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    F.lbruta.Text = GRIDDIAGRAMALL.Rows[e.RowIndex].Cells["Ruta"].Value.ToString();
                    byte[] byt = neg.TraerIMGMYSQL(Convert.ToInt32(GRIDDIAGRAMALL.Rows[e.RowIndex].Cells["ID_Diagrama"].Value)); //TRAE el img por id
                    F.pcitureImage.Image = E_Imagen.byteArrayToImage(byt); //de byte a img
                    F.ShowDialog();
                    MostrarTodos(FormLogin.ID_Usuario);
                }
            }
            catch (Exception EQ)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", EQ.Message);
            }

        }

        private void btnrefreshtodos_Click(object sender, EventArgs e)
        {
            MostrarTodos(FormLogin.ID_Usuario);
        }

        private void BTNREFRESHACT_Click(object sender, EventArgs e)
        {
            MostrarACT(FormLogin.ID_Usuario);
        }

        private void GRID_ACTIVO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (GRID_ACTIVO.Rows[e.RowIndex].Cells["VERACT"].Selected)
                {
                    FormVerImagen F = new FormVerImagen();
                    FormEditDiagram.ID_Diagrama = Convert.ToInt32(GRID_ACTIVO.Rows[e.RowIndex].Cells["ID_Diagrama"].Value);//id del diagrama
                    FormEditDiagram.DiagramaEditar = GRID_ACTIVO.Rows[e.RowIndex].Cells["ArchivoJson"].Value.ToString();
                    F.editar = Convert.ToBoolean(GRID_ACTIVO.Rows[e.RowIndex].Cells["Status_Activo"].Value.ToString());
                    F.lbnombre.Text = GRID_ACTIVO.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    F.lbruta.Text = GRID_ACTIVO.Rows[e.RowIndex].Cells["Ruta"].Value.ToString();
                    byte[] byt = neg.TraerIMGMYSQL(Convert.ToInt32(GRID_ACTIVO.Rows[e.RowIndex].Cells["ID_Diagrama"].Value)); //TRAE el img por id
                    F.pcitureImage.Image = E_Imagen.byteArrayToImage(byt); //de byte a img
                    F.ShowDialog();
                    MostrarACT(FormLogin.ID_Usuario);
                }
                if (GRID_ACTIVO.Rows[e.RowIndex].Cells["DESACTIVAR"].Selected)
                {
                    DialogResult result = new DialogResult();
                    FormPregunta of = new FormPregunta("ESTA SEGURO DE SU ACCION..", "SE ACTUALIZARA EL ESTADO DEL DIAGRAMA A DESACTIVADO, DESEA CONTINUAR??..");
                    result = of.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        int id = Convert.ToInt32(GRID_ACTIVO.Rows[e.RowIndex].Cells["ID_Diagrama"].Value);
                        neg.ActualizarStatus(id,false);
                        FormCompletado.Mensaje("COMPLETADO", "SE DESACTIVO CORRECTAMENTE!");
                        MostrarACT(FormLogin.ID_Usuario);
                    }
                }
                
            }
            catch (Exception EQ)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", EQ.Message);
            }
        }

        private void btnRefreshdeact_Click(object sender, EventArgs e)
        {
            MostrarDeact(FormLogin.ID_Usuario);
        }

        private void Grid_Desactivado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Grid_Desactivado.Rows[e.RowIndex].Cells["VERDEACT"].Selected)
                {
                    FormVerImagen F = new FormVerImagen();
                    FormEditDiagram.ID_Diagrama = Convert.ToInt32(Grid_Desactivado.Rows[e.RowIndex].Cells["ID_Diagrama"].Value); //id del diagrama
                    FormEditDiagram.DiagramaEditar = Grid_Desactivado.Rows[e.RowIndex].Cells["ArchivoJson"].Value.ToString();
                    F.editar = Convert.ToBoolean(Grid_Desactivado.Rows[e.RowIndex].Cells["Status_Activo"].Value.ToString());
                    F.lbnombre.Text = Grid_Desactivado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    F.lbruta.Text = Grid_Desactivado.Rows[e.RowIndex].Cells["Ruta"].Value.ToString();
                    byte[] byt = neg.TraerIMGMYSQL(Convert.ToInt32(Grid_Desactivado.Rows[e.RowIndex].Cells["ID_Diagrama"].Value)); //TRAE el img por id
                    F.pcitureImage.Image = E_Imagen.byteArrayToImage(byt); //de byte a img
                    F.ShowDialog();
                    MostrarDeact(FormLogin.ID_Usuario);
                }
                if (Grid_Desactivado.Rows[e.RowIndex].Cells["ACTIVAR"].Selected)
                {
                    DialogResult result = new DialogResult();
                    FormPregunta of = new FormPregunta("ESTA SEGURO DE SU ACCION..", "SE ACTUALIZARA EL ESTADO DEL DIAGRAMA A ACTIVADO, DESEA CONTINUAR??..");
                    result = of.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        int id = Convert.ToInt32(Grid_Desactivado.Rows[e.RowIndex].Cells["ID_Diagrama"].Value);
                        neg.ActualizarStatus(id, true);
                        FormCompletado.Mensaje("COMPLETADO", "SE ACTIVO CORRECTAMENTE!");
                        MostrarDeact(FormLogin.ID_Usuario);
                    }
                }
            }
            catch (Exception EQ)
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", EQ.Message);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if(tabControl1.SelectedTab.Name == "tbAllDiagrams") //refrescando cuando se cambia de tab los grid
                MostrarTodos(FormLogin.ID_Usuario);
            if (tabControl1.SelectedTab.Name == "tbActivo")
                MostrarACT(FormLogin.ID_Usuario);
            if (tabControl1.SelectedTab.Name == "tbInactivos")
                MostrarDeact(FormLogin.ID_Usuario);
        }
    }
}
