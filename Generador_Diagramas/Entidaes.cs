using MindFusion.Diagramming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador_Diagramas
{
    class Entidaes
    {
    }
    //clases
    public class NodoDragItem
    {
        public NodoDragItem(int inx)
        {
            indice = inx;
        }
        private int indice;
        public int Indice
        {
            get { return indice; }
        }
        public static Type _GetType()
        {
            return new NodoDragItem(0).GetType();
        }
    }
    public class Nodo
    {
        public Nodo(AnchorPattern ancho, Shape plantillas, string nombre)
        {
            anchor = ancho;
            template = plantillas;
            name = nombre;
        }
        private AnchorPattern anchor;
        public AnchorPattern Anchor
        {
            get { return anchor; }
        }
        private Shape template;
        public Shape Template
        {
            get { return template; }
        }
        private string name;
        public string Name
        {
            get { return name; }
        }
    }
    public class Conector
    {
        public Conector(Shape fgshape, string name)
        {
            figura = fgshape;
            nombre = name;
        }
        private Shape figura;
        public Shape Figura
        {
            get { return figura; }
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
        }
    }
    public class NodoProdiedades 
    {
        [Category("Propiedades")]
        [Description("El texto que se desplega en el nodo.")]
        private string texto;
        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        [Category("Propiedades")]
        [Description("La fuente Tipografica que contiene el nodo.")]
        private Font letra;
        public Font Letra
        {
            get { return letra; }
            set { letra = value; }
        }

        [Category("Propiedades")]
        [Description("El color que contiene el nodo.")]
        private Color llenadocolor;
        public Color LlenadoColor
        {
            get { return llenadocolor; }
            set { llenadocolor = value; }
        }
    }
}

