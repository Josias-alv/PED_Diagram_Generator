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

namespace Generador_Diagramas
{
    public partial class Formprincipal : Formbase
    {
        private IconButton currentBotton;
        public Formprincipal()
        {
            InitializeComponent();
            cargardatos();
            cusomizeDesign();
        }
        private void ActivateButtom(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButtom();
                currentBotton = (IconButton)senderBtn;
                currentBotton.BackColor = Color.FromArgb(30, 30, 46);
                currentBotton.ForeColor = color;
                currentBotton.TextAlign = ContentAlignment.MiddleCenter;
                currentBotton.IconColor = color;
                currentBotton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBotton.ImageAlign = ContentAlignment.MiddleRight;
                //leftbotderbuttom
                //Icono Panel top
                ActualSeleccionbox.IconChar = currentBotton.IconChar;
                ActualSeleccionbox.IconColor = color;
            }
        }
        private void DisableButtom()
        {
            if (currentBotton != null)
            {
                currentBotton.BackColor = Color.FromArgb(45,45,45);
                currentBotton.ForeColor = Color.Gainsboro;
                currentBotton.TextAlign = ContentAlignment.MiddleLeft;
                currentBotton.IconColor = Color.Gainsboro;
                currentBotton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBotton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void cusomizeDesign()
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
            if (SubmenuEditar.Visible == true)
                SubmenuEditar.Visible = false;
            if (SubmenuConvertir.Visible == true)
                SubmenuConvertir.Visible = false;
            if (SubmenuInformacion.Visible == true)
                SubmenuInformacion.Visible = false;
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
        //public Form formActivo = null;
        //public void AbrirForms(Form FormHijo)
        //{
        //    if (formActivo != null)
        //        formActivo.Close();
        //    formActivo = FormHijo;
        //    //le decimos que es un formulario hijo
        //    FormHijo.TopLevel = false;
        //    //le decimos que habarque todo el panel
        //    FormHijo.Dock = DockStyle.Fill;
        //    //agregando el form
        //    panelInvocarForms.Controls.Add(FormHijo);
        //    //obtiene sus datos
        //    panelInvocarForms.Tag = FormHijo;
        //    //poniendolo adelante
        //    FormHijo.BringToFront();
        //    FormHijo.Show();
        //}
        private void Reset()
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
            cusomizeDesign();
            Reset();
            ActivateButtom(sender, Color.FromArgb(95, 77, 221));
            DialogResult result = new DialogResult();
            FormPregunta of = new FormPregunta("CERRAR SESION..", "DESEA SALIR DEL PROGRAMA..");
            result = of.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                Reset();
            }
        }
        //FUNCIONALIDADES DE BOTONES
        private void btnnuevo_Click(object sender, EventArgs e)
        {
           Diagrama.ClearAll();//limpia el diagrama lo borra y limpia
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                if (OpenDialog.ShowDialog() == DialogResult.OK)
                {
                    Diagrama.LoadFromFile(OpenDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                FormError f = new FormError("ERROR EN ABRIR..", "TIPO DE ERROR: " + ex.Message);
                f.ShowDialog();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Diagrama.SaveToFile(SaveDialog.FileName, true);
                }
                catch (Exception ex)
                {
                    FormError f = new FormError("ERROR EN GUARDAR..", "TIPO DE ERROR: " + ex.Message);
                    f.ShowDialog();
                }
            }
        }

        private void BTNPDF_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDialog.DefaultExt = "pdf";
                SaveDialog.Filter = "PDF files|*.pdf";
                if (SaveDialog.ShowDialog() == DialogResult.OK)
                {
                    MindFusion.Diagramming.Export.PdfExporter pdfExp = new MindFusion.Diagramming.Export.PdfExporter();
                    pdfExp.Export(DiagramaVer.Diagram, SaveDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                FormError f = new FormError("ERROR EN CONVERCION..", "TIPO DE ERROR: " + ex.Message);
                f.ShowDialog();
            }
        }

        private void BTNSVG_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDialog.DefaultExt = "svg";
                SaveDialog.Filter = "SVG files|*.svg";
                if (SaveDialog.ShowDialog() == DialogResult.OK)
                {
                    MindFusion.Diagramming.Export.SvgExporter svgExp = new MindFusion.Diagramming.Export.SvgExporter();
                    svgExp.ExternalImages = false;
                    svgExp.Export(DiagramaVer.Diagram, SaveDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                FormError f = new FormError("ERROR EN CONVERCION..", "TIPO DE ERROR: " + ex.Message);
                f.ShowDialog();
            }
        }

        private void BTNPNG_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDialog.DefaultExt = "png";
                SaveDialog.Filter = "PNG files|*.png";
                if (SaveDialog.ShowDialog() == DialogResult.OK)
                {
                    Image image = Diagrama.CreateImage();
                    image.Save(SaveDialog.FileName);
                    image.Dispose();//LIBERA RECURSOS
                }
            }
            catch (Exception ex)
            {
                FormError f = new FormError("ERROR EN CONVERCION..", "TIPO DE ERROR: " + ex.Message);
                f.ShowDialog();
            }
        }

        private void BTNImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                DiagramaVer.PrintOptions.DocumentName = "Diagramonus";
                DiagramaVer.PrintOptions.EnableImages = false;
                DiagramaVer.PrintOptions.EnableInterior = true;
                DiagramaVer.PrintOptions.EnableShadows = true;
                DiagramaVer.PrintOptions.Scale = 100;
                DiagramaVer.PrintPreview();
            }
            catch (Exception ex)
            {
                FormError f = new FormError("ERROR EN REGRESAR.", "TIPO DE ERROR: " + ex.Message);
                f.ShowDialog();
            }
        }

        private void BTNAcerca_Click(object sender, EventArgs e)
        {
            FormInfo f = new FormInfo();
            f.ShowDialog();
        }
        private void BtnDeshacer_Click(object sender, EventArgs e)
        {
            try
            {
                Diagrama.UndoManager.Undo();
            }
            catch (Exception ex)
            {
                FormError f = new FormError("ERROR EN ABRIR..", "TIPO DE ERROR: " + ex.Message);
                f.ShowDialog();
            }
        }

        private void btnRehacer_Click(object sender, EventArgs e)
        {
            try
            {
                Diagrama.UndoManager.Redo();
            }
            catch (Exception ex)
            {
                FormError f = new FormError("ERROR EN ABRIR..", "TIPO DE ERROR: " + ex.Message);
                f.ShowDialog();
            }
        }

        //Propiedades para cargar datos
        private static Nodo[] nodos = null;
        private MarkStyle estiloancho = MarkStyle.Circle;
        private Color anchoColor = Color.Red;
        private static Conector[] conectores = null;
        private NodoProdiedades Seleccionado = null;
        private void DiagramaVer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(NodoDragItem._GetType()))
            {
                NodoDragItem ctor = (NodoDragItem)e.Data.GetData(NodoDragItem._GetType());
                if (ctor.Indice >= 0 && ctor.Indice < nodos.Length)
                {
                    Point punto = DiagramaVer.PointToClient(new Point(e.X, e.Y));
                    PointF puntofloat = DiagramaVer.ClientToDoc(new Point(punto.X, punto.Y));

                    AnchorPattern ancho = nodos[ctor.Indice].Anchor;
                    foreach (AnchorPoint item in ancho.Points)
                    {
                        item.MarkStyle = estiloancho;
                        item.Color = anchoColor;
                    }
                    ShapeNode ndgeo = Diagrama.Factory.CreateShapeNode(puntofloat, new Size(20, 20));
                    ndgeo.Shape = nodos[ctor.Indice].Template;
                    ndgeo.AnchorPattern = ancho;
                    ndgeo.HandlesStyle = HandlesStyle.DashFrame;
                }
            }
        }

        private void DiagramaVer_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(NodoDragItem._GetType()))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lstNODOList_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 32;
        }

        private void lstNODOList_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            hidden.ClearAll();
            if (e.Index < 0)
                return;
            LstBox_DibujarItem(lstNODOList, e);
            if ((e.State & DrawItemState.Selected) > 0)
                hidden.BackBrush = new MindFusion.Drawing.SolidBrush(Color.LightYellow);
            else
                hidden.BackBrush = new MindFusion.Drawing.SolidBrush(Color.White);

            // Dibuja el nodo
            ShapeNode nodo = hidden.Factory.CreateShapeNode(1, 1, 24, 24);
            nodo.Shape = nodos[e.Index].Template;

            Bitmap bmp = new Bitmap(32, 32);

            GdiGraphics g = new GdiGraphics(Graphics.FromImage(bmp));
            g.SmoothingMode = SmoothingMode.AntiAlias;
            RenderOptions ro = new RenderOptions();
            nodo.DrawShadow(g, ro);
            nodo.Draw(g, ro);
            g.Dispose();

            Rectangle rci = new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 4, 24, 24);
            e.Graphics.DrawImage(bmp, rci, 1, 1, 26, 26, GraphicsUnit.Pixel);

            bmp.Dispose();
        }
        private void LstBox_DibujarItem(ListBox lb, System.Windows.Forms.DrawItemEventArgs e)
        {
            Rectangle rcc;
            RectangleF rc;

            System.Drawing.SolidBrush brush;
            System.Drawing.Pen selPen;
            System.Drawing.SolidBrush selBrush;
            StringFormat sf;

            rcc = e.Bounds;
            rcc.Inflate(-1, -1);
            rc = new RectangleF((float)e.Bounds.Left + 32, e.Bounds.Top, (float)e.Bounds.Width - 32, e.Bounds.Height);

            brush = new System.Drawing.SolidBrush(Color.Black);
            selPen = new System.Drawing.Pen(Color.Goldenrod);
            selBrush = new System.Drawing.SolidBrush(Color.LightYellow);

            sf = StringFormat.GenericDefault;
            sf.LineAlignment = StringAlignment.Center;

            // Draw the selection if any
            if ((e.State & DrawItemState.Selected) > 0)
            {
                e.Graphics.FillRectangle(selBrush, rcc);
                e.Graphics.DrawRectangle(selPen, rcc);
            }
            else
            {
                System.Drawing.SolidBrush tb = new System.Drawing.SolidBrush(Color.White);
                e.Graphics.FillRectangle(tb, e.Bounds);
                tb.Dispose();
            }

            e.Graphics.DrawString((string)lb.Items[e.Index], lstNODOList.Font, brush, rc, sf);

            brush.Dispose();
            selPen.Dispose();
            selBrush.Dispose();
        }

        private void lstNODOList_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(new NodoDragItem(lstNODOList.SelectedIndex), DragDropEffects.Copy);
        }

        private void lstFlechasConectors_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 32;
        }

        private void lstFlechasConectors_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            //Dibuja las flechas
            LstBox_DibujarItem(lstFlechasConectors, e);

            System.Drawing.Pen pen = new System.Drawing.Pen(Color.Black);
            Point p0 = new Point(e.Bounds.X + 2, e.Bounds.Y + 13);
            Point p1 = new Point(e.Bounds.X + 19, e.Bounds.Y + 13);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(Pens.Black, p0, p1);

            DiagramLink.DrawArrowhead(new GdiGraphics(e.Graphics), pen, Brushes.LightSkyBlue, conectores[e.Index].Figura, new PointF(50, 0), p1, p0, 12F, false);

            pen.Dispose();//libera recursos
            //Dibuja las flechas
        }

        private void lstFlechasConectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = lstFlechasConectors.SelectedIndex;
            if (selected < 0 || selected >= conectores.Length)
                return;

            Diagrama.LinkHeadShape = conectores[selected].Figura;
        }
        private void PropiedadEditChange(object s, PropertyValueChangedEventArgs e)
        {
            if (Diagrama.Selection.Nodes.Count == 0)
                return;

            ShapeNode shape = Diagrama.Selection.Nodes[0] as ShapeNode;
            if (shape == null)
                return;

            // Crear una propiedad
            ChangeItemCmd cmd = new ChangeItemCmd(shape, "Property change");

            shape.Text = Seleccionado.Texto;
            shape.Font = Seleccionado.Letra;
            shape.Brush = new MindFusion.Drawing.SolidBrush(Seleccionado.LlenadoColor);

            cmd.Execute();
        }

        private void CBMTipoFlechaConectors_SelectedValueChanged(object sender, EventArgs e)
        {
            LinkShape shape = LinkShape.Polyline;
            short segmentos = 1;

            switch (CBMTipoFlechaConectors.SelectedIndex)
            {
                case 0:
                    shape = LinkShape.Polyline;
                    break;
                case 1:
                    shape = LinkShape.Bezier;
                    break;
                case 2:
                    shape = LinkShape.Cascading;
                    segmentos = 3;
                    break;
            }

            Diagrama.LinkShape = shape;
            Diagrama.LinkSegments = segmentos;
        }
        private void Delete(object sender, EventArgs e)
        {
            if (Diagrama.Selection.Nodes.Count > 0)
                Diagrama.Nodes.Remove(Diagrama.Selection.Nodes[0]);
            if (Diagrama.Selection.Links.Count > 0)
                Diagrama.Links.Remove(Diagrama.Selection.Links[0]);
        }

        private void Diagrama_LinkClicked(object sender, LinkEventArgs e)
        {
            if (e.MouseButton != MouseButton.Right)
                return;

            Point punto = DiagramaVer.DocToClient(e.MousePosition);
            ContextMenu.Show(DiagramaVer, punto);
        }

        private void Diagrama_NodeActivated(object sender, NodeEventArgs e)
        {
            ShapeNode nodo = e.Node as ShapeNode;
            if (nodo != null)
            {
                Seleccionado = new NodoProdiedades();
                Seleccionado.Texto = nodo.Text;
                Seleccionado.Letra = nodo.EffectiveFont;
                Seleccionado.LlenadoColor = (nodo.EffectiveBrush as MindFusion.Drawing.SolidBrush).Color;

                GridPropiedades.SelectedObject = Seleccionado;
            }
        }

        private void Diagrama_NodeClicked(object sender, NodeEventArgs e)
        {
            if (e.MouseButton != MouseButton.Right)
                return;

            Point punto = DiagramaVer.DocToClient(e.MousePosition);
            ContextMenu.Show(DiagramaVer, punto);
        }

        private void Diagrama_NodeDeactivated(object sender, NodeEventArgs e)
        {
            GridPropiedades.SelectedObject = null;
            Seleccionado = null;
        }
        private void cargardatos()
        {
            Diagrama.BackBrush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(250, 247, 238));//color diagrama de trabajo
            Diagrama.ShapeNodeStyle.Brush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(244, 246, 241));//color figura(nodo) por defecto el relleno
            Diagrama.ShapeNodeStyle.Stroke = new MindFusion.Drawing.SolidBrush(Color.FromArgb(8,11,9));//bordes de el nodo
            Diagrama.DiagramLinkStyle.Brush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(102, 154, 204));//color de la flecha punta
            Diagrama.DiagramLinkStyle.Stroke = new MindFusion.Drawing.SolidBrush(Color.FromArgb(45, 45, 45));//color de la linea que lleva a la punta
            Color defAnch = Color.Red;
            nodos = new Nodo[]
            {
                new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("Alternative"), // get shape by string id
						"Alternative"),
                new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(30, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 30, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("PunchedCard"),
                        "Card"),
                    new Nodo(
                        AnchorPattern.Decision2In2Out,
                        Shape.FromId("Decision"),
                        "Decision"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("Delay"),
                        "Delay"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(15, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(85, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(85, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(15, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shapes.DirectAccessStorage,
                        "Direct data"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 20, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 80, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 80, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 20, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("DiskStorage"),
                        "DiskStorage"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(40, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(85, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(85, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(40, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("Display"),
                        "Display"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("DividedEvent"),
                        "Divided event"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("DividedProcess"),
                        "Divided process"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 90, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 90, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 90, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("Document"),
                        "Document"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("InternalStorage"),
                        "Internal storage"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(25, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(75, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 25, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 25, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("BeginLoop"),
                        "Loop limit"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(50, 20, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 40, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("Input"),
                        "Manual input"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(80, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(20, 100, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("ManualOperation"),
                        "Manual operation"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(80, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("MessageFromUser"),
                        "Message from User"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(20, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(20, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("MessageToUser"),
                        "Message to User"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(45, 90, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 90, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("MultiDocument"),
                        "Multi-document"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(0, 10, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 10, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 10, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 90, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 90, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 90, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("Microform"),
                        "Paper tape"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(80, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("PrimitiveFromCall"),
                        "Primitive from Call"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(20, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(20, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("PrimitiveToCall"),
                        "Primitive to Call"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(0, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("Procedure"),
                        "Procedure"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(15, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(85, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 30, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 70, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(15, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(85, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 30, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 70, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("Start"),
                        "Start"),
                    new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, defAnch)
                        }),
                        Shape.FromId("Tape"),
                        "Tape")
            };
            foreach (Nodo nodo in nodos)
                lstNODOList.Items.Add(nodo.Name);
            conectores = new Conector[]
            {
                new Conector(ArrowHeads.Arrow,"Arrow"),
                new Conector(ArrowHeads.BackSlash,"Back slash"),
                new Conector(ArrowHeads.BowArrow,"Bow arrow"),
                new Conector(ArrowHeads.Circle,"Circle"),
                new Conector(ArrowHeads.DoubleArrow,"Double arrow"),
                new Conector(ArrowHeads.None,"None"),
                new Conector(ArrowHeads.Pentagon,"Pentagon"),
                new Conector(ArrowHeads.PointerArrow,"Pointer"),
                new Conector(ArrowHeads.Quill,"Quill"),
                new Conector(ArrowHeads.Reversed,"Reversed"),
                new Conector(ArrowHeads.RevTriangle,"Reversed triangle"),
                new Conector(ArrowHeads.RevWithCirc,"Reversed with Circle"),
                new Conector(ArrowHeads.RevWithLine,"Reversed with Line"),
                new Conector(ArrowHeads.Rhombus,"Rhombus"),
                new Conector(ArrowHeads.Slash,"Slash"),
                new Conector(ArrowHeads.Tetragon,"Tetragon"),
                new Conector(ArrowHeads.Triangle,"Triangle")
            };
            foreach (Conector connector in conectores)
                lstFlechasConectors.Items.Add(connector.Nombre);

            lstNODOList.SelectedIndex = 0;
            lstFlechasConectors.SelectedIndex = 0;
            CBMTipoFlechaConectors.SelectedIndex = 0;

            hidden.Bounds = new RectangleF(0, 0, 50, 50);
            hidden.RestrictItemsToBounds = RestrictToBounds.NoRestriction;

            Diagrama.Selection.AllowMultipleSelection = false;
            Diagrama.LinkCascadeOrientation = MindFusion.Diagramming.Orientation.Auto;
        }
        private void CTRZ_CRTX(object sender, EventArgs e)
        {
            //if (Diagrama.UndoManager.History.NextUndo != null)
            //{
            //	_menuUndo.Enabled = true;
            //	_menuUndo.Text = "Undo " + Diagrama.UndoManager.History.NextUndo.Title;
            //}
            //else
            //{
            //	_menuUndo.Enabled = false;
            //	_menuUndo.Text = "Undo";
            //}
            //if (Diagrama.UndoManager.History.NextRedo != null)
            //{
            //	_menuRedo.Enabled = true;
            //	_menuRedo.Text = "Redo " + Diagrama.UndoManager.History.NextRedo.Title;
            //}
            //else
            //{
            //	_menuRedo.Enabled = false;
            //	_menuRedo.Text = "Redo";
            //}
        }

        
    }
}
