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
using Generador_Diagramas.Formbases;
using MindFusion.Diagramming; // framework que nos ayudo a diagramar
using MindFusion.Diagramming.Commands; //nos ayuda a editar info del property grid de cada nodo
using MindFusion.Drawing; // contiene metodos parecidos a .drawing pero para cosas de mindfusion sitene que ser este
using Capa_Entidades;
using Capa_Negocio;
using System.IO;
namespace Generador_Diagramas
{
    class Procesos
    {
        public Procesos()
        {
            //...
        }
        //inicializando atributos
        private static List<Nodo> nodos = null;
        private static List<Conector> conectores = null;
        private NodoPropiedades Seleccionado = null;
        
        public void CargarDatos(ref Diagram Diagrama,ref ListBox lstnodos , ref ListBox lstflechas)
        {
            //midfusion.solidbrush es como el color. de c#
            Diagrama.BackBrush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(250, 247, 238));//color zona de trabajo el diagramaview
            Diagrama.ShapeNodeStyle.Brush = new MindFusion.Drawing.SolidBrush(Color.FromArgb(244, 246, 241));//color figura(nodo) por defecto el relleno
            Diagrama.ShapeNodeStyle.Stroke = new MindFusion.Drawing.SolidBrush(Color.FromArgb(8, 11, 9));//bordes de el nodo
            Diagrama.DiagramLinkStyle.Brush = new MindFusion.Drawing.SolidBrush(Color.Black);//color de la flecha punta
            Diagrama.DiagramLinkStyle.Stroke = new MindFusion.Drawing.SolidBrush(Color.FromArgb(45, 45, 45));//color de la linea que lleva a la punta
            Color Rojo = Color.Red;//color para los circulos de conexion entre nodos
            
            nodos = new List<Nodo>()
            {
                // agregando nodos a los listbox
                 new Nodo(
                        new AnchorPattern(new AnchorPoint[] //LOS ANCHORPATTERN se pueden almacenar muchos anchorpoints
                        {
                            new AnchorPoint(0, 0, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, Rojo), // un anchorpOINnt es donde se podran conectar las flechas en la figura
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(0, 100, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, Rojo)
                        }),
                        Shape.FromId("DividedEvent"),"Cuadrado Redondeado"),
                new Nodo(
                        new AnchorPattern(new AnchorPoint[]
                        {
                            new AnchorPoint(0, 0, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(50, 0, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(100, 0, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(100, 50, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(100, 100, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(50, 100, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(0, 100, true, true, MarkStyle.Circle, Rojo),
                            new AnchorPoint(0, 50, true, true, MarkStyle.Circle, Rojo)
                        }),Shape.FromId("DividedProcess"), "Cuadro"),            //Shapes.DividedProcess //cuadro aca todas las opciones que se pueden agregar
               
            };
            conectores = new List<Conector>()
            {
                new Conector(ArrowHeads.Arrow,"Punta de Flecha"),//
                new Conector(ArrowHeads.PointerArrow,"Punta de Flecha Rellena"),//
                new Conector(ArrowHeads.Triangle,"Punta de Triangulo")//
            };
            foreach (Nodo nodo in nodos)
                lstnodos.Items.Add(nodo.Nombre);
            foreach (Conector connector in conectores)
                lstflechas.Items.Add(connector.Nombre);
            lstnodos.SelectedIndex = 0;
            lstflechas.SelectedIndex = 0;
        }
        public void FlechasSelected_Evento(ref Diagram Diagrama, ref ListBox lstflechas)
        {
            int selected = lstflechas.SelectedIndex;
            if (selected < 0 || selected >= conectores.Count)
                return;

            Diagrama.LinkHeadShape = conectores[selected].Figura;  // le dice al diagrama que tipo de flecha sera dibujada en el
            
        }
        public void lstNodos_DrawItem_Evento( ref ListBox lstnodo, ref System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            Lst_AcoplarStr(ref lstnodo, ref e);
        }
        //metodo para dibujar items en lst
        private void Lst_AcoplarStr(ref ListBox lst, ref System.Windows.Forms.DrawItemEventArgs e)
        {
            Rectangle rectangulo = e.Bounds;
            rectangulo.Inflate(-1, -1);//Este método agranda o disminuye este rectángulo,
            StringFormat texto;
            texto = StringFormat.GenericDefault;
            texto.Alignment = StringAlignment.Center;
            texto.LineAlignment = StringAlignment.Center;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) //subraya o cambia el fondo delo seleccionado en el lst
            {
                e.Graphics.FillRectangle(Brushes.Gainsboro, e.Bounds);
                e.Graphics.DrawRectangle(new System.Drawing.Pen(Color.FromArgb(45, 45, 45)), rectangulo);//para las lineas como borde
            }
            else//cuando se deselecciona
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds); // reseta lo seleccionado ablanco
            }
            e.Graphics.DrawString(lst.Items[e.Index].ToString(), lst.Font, Brushes.Black, rectangulo, texto);//dibuja el texto en el rectangulo

        }
        public void lstFlechas_DrawItem_Evento(ref ListBox lstflechas, ref System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            //Dibuja las flechas
            Lst_AcoplarStr(ref lstflechas, ref e);
        }
        public void Diagrama_DragDrop_Evento(ref MindFusion.Diagramming.WinForms.DiagramView DiagramaVer, ref Diagram Diagrama ,ref DragEventArgs e) // evonto de arrastrar nodoss
        {
            if (e.Data.GetDataPresent(Nodo.Tipo()))//para ver qué tipos de datos están presentes
            {
                Nodo ctor = (Nodo)e.Data.GetData(Nodo.Tipo());//usa GetData para obtener los datos y los muestra.
                if (ctor.Indice >= 0 && ctor.Indice < nodos.Count)
                {
                    Point punto = DiagramaVer.PointToClient(new Point(e.X, e.Y));//convirtiendo coordenadas del donde se dragueo ,,la ubicación de la imagen igual al punto de caída
                    PointF puntocurrent = DiagramaVer.ClientToDoc(new Point(punto.X, punto.Y)); //CONVERTIR el punto donde lo puso a cordenadas del diagram ya que punto es de todo el form y este de solo el diagrama
                    //dibuja en cordenadas el nodo segun lo seleccionado
                    AnchorPattern ancho = nodos[ctor.Indice].Anchor;//puntos del anchor de la figura
                    ShapeNode nodo = Diagrama.Factory.CreateShapeNode(puntocurrent, new Size(20, 20)); // valor cuando se arrastre y pegue
                    nodo.Shape = nodos[ctor.Indice].Figura;// se convierte a la figura seleccionada
                    nodo.AnchorPattern = ancho; // annade los puntos para las flechas

                }
            }
        } 
        public void NODO_SINCLICK(ref PropertyGrid GRID)
        {
            //cuando no esta seleccionado ningun nodo
            GRID.SelectedObject = null;
            Seleccionado = null;
        }
        public void EditarPropiedasdes(ref Diagram Diagrama)
        {
            if (Diagrama.Selection.Nodes.Count == 0)
            {
                return;
            }
            ShapeNode shape = Diagrama.Selection.Nodes[0] as ShapeNode; //nodo seleccionado
            if (shape == null)
            {
                return;
            }

            // Crear una propiedad de nodos
            ChangeItemCmd cmd = new ChangeItemCmd(shape, "CambioDePropiedades"); //sirve para hacer o editar propiedades de un elemento este caso nodos

            shape.Text = Seleccionado.Texto;
            shape.Font = Seleccionado.Fuente;
            shape.TextBrush = new MindFusion.Drawing.SolidBrush(Seleccionado.ColorFuente);
            shape.Brush = new MindFusion.Drawing.SolidBrush(Seleccionado.Relleno);
            shape.Weight = Seleccionado.Duracion; // es el peso asignado a cada nodo
            cmd.Execute();
        }

        public void VerPropiedadesNodo(ref PropertyGrid GRID, ref NodeEventArgs e)
        {
            ShapeNode nodo = e.Node as ShapeNode;
            if (nodo != null)
            {
                Seleccionado = new NodoPropiedades();
                Seleccionado.Texto = nodo.Text;
                Seleccionado.Fuente = nodo.EffectiveFont;
                Seleccionado.ColorFuente = (nodo.EffectiveTextBrush as MindFusion.Drawing.SolidBrush).Color;
                Seleccionado.Relleno = (nodo.EffectiveBrush as MindFusion.Drawing.SolidBrush).Color;
                Seleccionado.Duracion = Convert.ToInt32(nodo.Weight);
                GRID.SelectedObject = Seleccionado; //pasando la info actual del nodo al property grid
            }
        }
        public void deleteNodoFlecha(ref Diagram Diagrama)
        {
            if (Diagrama.Selection.Nodes.Count > 0 || Diagrama.Selection.Links.Count > 0) //si esta seleccionado un shape o un link(flecha)
            {
                if (Diagrama.Selection.Nodes.Count > 0)
                    Diagrama.Nodes.Remove(Diagrama.Selection.Nodes[0]); //quita nodo
                if (Diagrama.Selection.Links.Count > 0)
                    Diagrama.Links.Remove(Diagrama.Selection.Links[0]); //quita links(flechas)
            }
            else
            {
                FormError.Mensaje("ERROR...", "SELECCIONE LA FLECHA O EL NODO A ELIMINAR...");
            }
        }
        public void AbrirARCH(ref OpenFileDialog ra , ref Diagram Diagrama) //abrir el archivo
        {
            try
            {
                ra.DefaultExt = "idg";//extension personalizada idg ideal diagram gag-bit , juego de palabras aleatorias !!
                ra.Filter = "Diagram files|*.idg";
                if (ra.ShowDialog() == DialogResult.OK)
                {
                    Diagrama.LoadFromFile(ra.FileName); //carga el contenido binario de un diagrama .
                }
            }
            catch (Exception ex)
            {
                FormError.Mensaje("ERROR", ex.Message);
            }
        }
        N_History neg = new N_History(); //nos ayuda  A TRAER METODOS para los diagramas guardados en MYSQL
        public void GuardarARCH(ref SaveFileDialog SAVE , ref Diagram Diagrama)
        {
            SAVE.DefaultExt = "idg";//extension personalizada
            SAVE.Filter = "Diagram files|*.idg";
            if (SAVE.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nombrearch = System.IO.Path.GetFileNameWithoutExtension(SAVE.FileName); //ontener el nombre sin extension
                    string nombreruta = System.IO.Path.GetDirectoryName(SAVE.FileName);
                    string TODAY = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    Diagrama.SaveToFile(SAVE.FileName, true); //Guarda el contenido binario de un diagrama en la secuencia en el archivo idg
                    Image img = Diagrama.CreateImage();
                    byte[] image = E_Imagen.ImageToByte(img);
                    E_Diagramas entities = new E_Diagramas();
                    entities.Id_Usuario = FormLogin.ID_Usuario;
                    entities.Nombre = nombrearch;
                    entities.archivoJson = Diagrama.SaveToJson(); //NOS DEVUELVE UN STRING EN FORMATO JSON CON TODO LO NECESARIO PARA RESTAURAR EL DIAGRAMA
                    entities.ArchivoPNG = image.ToArray();
                    entities.Ruta = nombreruta; 
                    entities.Fecha = Convert.ToDateTime(TODAY);
                    entities.Status = true;
                    neg.CrearDiagrama(entities); //crea un diagrama en base de datos
                    FormCompletado.Mensaje("ACTIVIDAD REALIZADA", "EL ARCHIVO SE HA GUARDADO CORRECTAMENTE...");
                    img.Dispose();//LIBERA RECURSOS
                }
                catch (Exception ex)
                {
                    FormError.Mensaje("ERROR", ex.Message);
                }
            }
        }
        public void EditarDiagramaMYSQL(ref Diagram Diagrama,string Nombre,int iddiagrama) //edita el diagrama guardado en la nube(base de datos)
        {
            try
            {
                string TODAY = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                Image img = Diagrama.CreateImage();
                byte[] image = E_Imagen.ImageToByte(img);
                E_Diagramas entities = new E_Diagramas();
                entities.Id_Diagrama = iddiagrama;
                entities.Nombre = Nombre;
                entities.archivoJson = Diagrama.SaveToJson(); //nos da un string en formato json que guarda el diagrama con sus datos
                entities.ArchivoPNG = image.ToArray();
                entities.FechaEdicion = Convert.ToDateTime(TODAY);
                neg.EditarDiagramaMYSQL(entities); //nos ayuda a editar el diagrama
                FormCompletado.Mensaje("ACTIVIDAD REALIZADA", "EL REGISTRO SE HA EDITADO CORRECTAMENTE...");
                img.Dispose();//LIBERA RECURSOS
            }
            catch (Exception ex)
            {
                FormError.Mensaje("ERROR", ex.Message);
            }
        }
        public void EditarDiagramaConRuta(ref Diagram Diagrama, string Nombre, int iddiagrama, ref SaveFileDialog SAVE) //con modificar su ruta
        {
            SAVE.DefaultExt = "idg";//extension personalizada
            SAVE.Filter = "Diagram files|*.idg";
            if(SAVE.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string nombreruta = System.IO.Path.GetDirectoryName(SAVE.FileName);
                    string TODAY = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    Diagrama.SaveToFile(SAVE.FileName, true);
                    Image img = Diagrama.CreateImage();
                    byte[] image = E_Imagen.ImageToByte(img);
                    E_Diagramas entities = new E_Diagramas();
                    entities.Id_Diagrama = iddiagrama;
                    entities.Nombre = Nombre;
                    entities.archivoJson = Diagrama.SaveToJson(); //nos da un string en formato json que guarda el diagrama con sus datos
                    entities.ArchivoPNG = image.ToArray();
                    entities.Ruta = nombreruta;
                    entities.FechaEdicion = Convert.ToDateTime(TODAY);
                    neg.EditDiagramConRuta(entities); //nos ayuda a editar el diagrama
                    FormCompletado.Mensaje("ACTIVIDAD REALIZADA", "EL REGISTRO SE HA EDITADO Y GUARDADO CORRECTAMENTE...");
                    img.Dispose();//LIBERA RECURSOS
                }
                catch (Exception ex)
                {
                    FormError.Mensaje("ERROR", ex.Message);
                }
            }
           
        }
 
        public void ConvertPDF(ref SaveFileDialog SAVE, ref MindFusion.Diagramming.WinForms.DiagramView DiagramaVer)
        {
            SAVE.DefaultExt = "pdf";
            SAVE.Filter = "PDF files|*.pdf";
            if (SAVE.ShowDialog() == DialogResult.OK)
            {
                MindFusion.Diagramming.Export.PdfExporter pdfExp = new MindFusion.Diagramming.Export.PdfExporter();//llamando funcion que nos ayuda a convertir a pdf
                pdfExp.Export(DiagramaVer.Diagram, SAVE.FileName); //convierte el diagrama en pdf
                FormCompletado.Mensaje("ACTIVIDAD REALIZADA", "EL ARCHIVO SE EXPORTO CORRECTAMENTE...");
            }
        }
        public void ConvertPNG(ref SaveFileDialog SAVE, ref Diagram Diagrama) //convierte a pdf
        {
            SAVE.DefaultExt = "png";
            SAVE.Filter = "PNG files|*.png";
            if (SAVE.ShowDialog() == DialogResult.OK)
            {   
                Image image = Diagrama.CreateImage(); 
                image.Save(SAVE.FileName);
                image.Dispose();//LIBERA RECURSOS
                FormCompletado.Mensaje("ACTIVIDAD REALIZADA", "EL ARCHIVO SE EXPORTO CORRECTAMENTE...");
            }
        }
    }
}
