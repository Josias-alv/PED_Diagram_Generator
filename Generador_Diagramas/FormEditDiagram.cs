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
    public partial class FormEditDiagram : InvocadoBase
    {
        public FormEditDiagram()
        {
            InitializeComponent();
            Process.CargarDatos(ref diagram1,ref lstNODOList,ref lstFlechasConectors);
            diagram1.LoadFromJson(DiagramaEditar); //cargara el diagrama seleccionado..
        }

        Procesos Process = new Procesos(); //nos ayudara para los procesos del diagrama
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            FormPregunta of = new FormPregunta("PREGUNTA SERIA..", "SI LE DA ACEPTAR SE CERRARA LA EDICION DEL DIAGRAMA Y NO SE EFECTURA EL CAMBIO, ¿ DESEA CONTINUAR ?");
            result = of.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        public static int ID_Diagrama; // IDdiagrama
        public static string DiagramaEditar; //diagrama a editar
        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            Process.deleteNodoFlecha(ref diagram1);
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtnombre.Text))
                {
                    FormError.Mensaje("ERROR", "NO PUEDE INGRESAR DATOS NULOS !!!");
                }
                else
                {
                    Process.EditarDiagramaMYSQL(ref diagram1, txtnombre.Text,ID_Diagrama);
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                FormError.Mensaje("ERROR", ex.Message);
            }
        }

        private void DiagramaVer_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(Nodo.Tipo()))//Determina si los datos están disponibles o se pueden convertir a un formato especificado.
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lstNODOList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 38;
        }

        private void lstFlechasConectors_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 38;
        }

        private void lstNODOList_DrawItem(object sender, DrawItemEventArgs e)
        {
            Process.lstNodos_DrawItem_Evento(ref lstNODOList, ref e);
        }

        private void lstNODOList_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(new Nodo(lstNODOList.SelectedIndex), DragDropEffects.Copy);//inicia la operacion de agarra y soltar con el icono copy
        }

        private void lstFlechasConectors_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Process.lstFlechas_DrawItem_Evento(ref lstFlechasConectors, ref e);
            }
            catch (Exception ex)
            {
                FormError.Mensaje("ERROR", ex.Message);
            }
        }

        private void lstFlechasConectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process.FlechasSelected_Evento(ref diagram1, ref lstFlechasConectors);
        }

        private void GridPropiedades_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            try
            {
                Process.EditarPropiedasdes(ref diagram1);
            }
            catch (Exception ex)
            {
                FormError.Mensaje("ERROR", ex.Message);
            }
        }

        private void diagram1_NodeClicked(object sender, MindFusion.Diagramming.NodeEventArgs e)
        {
            try
            {
                Process.VerPropiedadesNodo(ref GridPropiedades, ref e);
            }
            catch (Exception ex)
            {
                FormError.Mensaje("ERROR", ex.Message);
            }
        }

        private void diagram1_NodeDeactivated(object sender, MindFusion.Diagramming.NodeEventArgs e)
        {
            Process.NODO_SINCLICK(ref GridPropiedades);
        }

        private void DiagramaVer_DragDrop(object sender, DragEventArgs e)
        {
            Process.Diagrama_DragDrop_Evento(ref DiagramaVer, ref diagram1, ref e);
        }

        private void paneltop_MouseDown(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0); //mover form
        }
        //nos ayuda a mover el form con mantener click en el panel.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
    }
}
