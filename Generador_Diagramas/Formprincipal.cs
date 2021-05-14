using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Generador_Diagramas.Formbases;
using MindFusion.Diagramming;
using MindFusion.Diagramming.Commands;
using MindFusion.Drawing;
using Capa_Entidades;
using Capa_Negocio;

namespace Generador_Diagramas
{
    public partial class Formprincipal : Formbase
    {
        private IconButton BotonSeleccionado;
        public Formprincipal()
        {
            InitializeComponent();
            Process.CargarDatos(ref Diagrama, ref lstNODOList, ref lstFlechasConectors);//*,ref CBMTipoFlechaConectors*/); //cargan los datos de las diferentes figuras y flechas , como el area de diagramas
            ValoresDefectos();
        }
        private void ActivateButtom(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButtom();
                BotonSeleccionado = (IconButton)senderBtn;
                BotonSeleccionado.BackColor = Color.FromArgb(30, 30, 46);
                BotonSeleccionado.ForeColor = color;
                BotonSeleccionado.TextAlign = ContentAlignment.MiddleCenter;
                BotonSeleccionado.IconColor = color;
                BotonSeleccionado.TextImageRelation = TextImageRelation.TextBeforeImage;
                BotonSeleccionado.ImageAlign = ContentAlignment.MiddleRight;
                ActualSeleccionbox.IconChar = BotonSeleccionado.IconChar;
                ActualSeleccionbox.IconColor = color;
            }
        }
        private void DisableButtom() //valores al inicio del form
        {
            if (BotonSeleccionado != null)
            {
                BotonSeleccionado.BackColor = Color.FromArgb(45,45,45);
                BotonSeleccionado.ForeColor = Color.Gainsboro;
                BotonSeleccionado.TextAlign = ContentAlignment.MiddleLeft;
                BotonSeleccionado.IconColor = Color.Gainsboro;
                BotonSeleccionado.TextImageRelation = TextImageRelation.ImageBeforeText;
                BotonSeleccionado.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void ValoresDefectos() //por defecto
        {
            SubmenuArchivo.Visible = false;
            SubmenuEditar.Visible = false;
            SubmenuConvertir.Visible = false;
            SubmenuInformacion.Visible = false;
            //..
        }
        private void HideSubmenu()
        {
            if (SubmenuArchivo.Visible == true)
                SubmenuArchivo.Visible = false;
            if (SubmenuConvertir.Visible == true)
                SubmenuConvertir.Visible = false;
            if (SubmenuEditar.Visible == true)
                SubmenuEditar.Visible = false;
            if (SubmenuInformacion.Visible == true)
                SubmenuInformacion.Visible = false;

            //if (submenu.Visible == true)
            //    submenu.Visible = false;
            //..
        }
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void Reset() //resetea los botones y el logo de seleccion
        {
            DisableButtom();
            ActualSeleccionbox.IconChar = IconChar.Home;
            ActualSeleccionbox.IconColor = Color.Gainsboro;
        }

        private void BTNArchivo_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, Color.FromArgb(95, 77, 221));
            ShowSubMenu(SubmenuArchivo);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, Color.FromArgb(95, 77, 221));
            ShowSubMenu(SubmenuEditar);
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, Color.FromArgb(95, 77, 221));
            ShowSubMenu(SubmenuConvertir);
        }

        private void BTNINFO_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, Color.FromArgb(95, 77, 221));
            ShowSubMenu(SubmenuInformacion);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            ValoresDefectos();
            Reset();
            ActivateButtom(sender, Color.FromArgb(95, 77, 221));
            DialogResult result = new DialogResult();
            FormPregunta of = new FormPregunta("CERRAR SESION..", "DESEA SALIR DEL PROGRAMA..");
            result = of.ShowDialog();
            if(result == DialogResult.OK)
            {
                FormLogin fo = new FormLogin();
                this.Hide();
                fo.Show();
            }
            else
            {
                Reset();
            }
        }
        //FUNCIONALIDADES DE BOTONES

        //funcionalidades para diagramar   
        //DiagramaVer es el DiagramView control de winforms donde vemos y arrastramos el diagrama que automaticamente crea un Diagram que es como una copia donde se efectuan los cambios
        //donde estan los datos es como una copia de seguridad de todo lo que hacemos en el DiagramView
        Procesos Process = new Procesos();
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                FormPregunta of = new FormPregunta("ESTA SEGURO DE SU ACCION..", "SE PERDERA TODOS LOS DATOS NO GUARDADOS, DESEA CONTINUAR??..");
                result = of.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Diagrama.ClearAll();//limpia el diagrama lo borra y limpia
                }
            }
            catch (Exception ex)
            {
                FormError.Mensaje("ERROR", ex.Message);
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                Process.AbrirARCH(ref OpenDialog, ref Diagrama);
            }
            catch (Exception ex)
            {
                FormError.Mensaje("ERROR", ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Process.GuardarARCH(ref SaveDialog, ref Diagrama);
            }
            catch (Exception ex)
            {
                FormError.Mensaje("ERROR", ex.Message);
            }
        }

        private void BTNPDF_Click(object sender, EventArgs e)
        {
            try
            {
                Process.ConvertPDF(ref SaveDialog, ref DiagramaVer);
            }
            catch (Exception ex)
            {
                FormError.Mensaje("ERROR", ex.Message);
            }
        }

        private void BTNPNG_Click(object sender, EventArgs e)
        {
            try
            {
                Process.ConvertPNG(ref SaveDialog, ref Diagrama);
            }
            catch (Exception ex)
            {
                FormError.Mensaje("ERROR", ex.Message);
            }
        }

        private void BTNAcerca_Click(object sender, EventArgs e)
        {
            FormInfo f = new FormInfo();
            f.ShowDialog();
        }
        
        private void DiagramaVer_DragDrop(object sender, DragEventArgs e)
        {
            Process.Diagrama_DragDrop_Evento(ref DiagramaVer, ref Diagrama, ref e);
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

        private void lstNODOList_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Process.lstNodos_DrawItem_Evento(ref lstNODOList,ref e);
        }
        private void lstNODOList_MouseDown(object sender, MouseEventArgs e)// al presionar el mouse
        {                                              
            DoDragDrop(new Nodo(lstNODOList.SelectedIndex), DragDropEffects.Copy);//inicia la operacion de agarra y soltar con el icono copy
        }

        private void lstFlechasConectors_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 38;
        }

        private void lstFlechasConectors_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
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
            Process.FlechasSelected_Evento(ref Diagrama, ref lstFlechasConectors);
        }
        private void PropiedadEditChange(object s, PropertyValueChangedEventArgs e)
        {
            try
            {
                Process.EditarPropiedasdes(ref Diagrama);
            }
            catch (Exception ex)
            {
                FormError.Mensaje("ERROR", ex.Message);
            }
        }

        private void CBMTipoFlechaConectors_SelectedValueChanged(object sender, EventArgs e)
        {
            //
        }

        private void Diagrama_NodeDeactivated(object sender, NodeEventArgs e)
        {
            Process.NODO_SINCLICK(ref GridPropiedades);
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Process.Verificarcarpeta("hola");
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            FormSetting f = new FormSetting();
            f.ShowDialog();
            //..
        }

        private void btneliminar_Click(object sender, EventArgs e)//ELIMINA EL NODO O FLECHA
        {
            Process.deleteNodoFlecha(ref Diagrama);
        }

        private void Diagrama_NodeClicked(object sender, NodeEventArgs e) //evento click en el nodo
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
    }
}
