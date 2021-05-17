using MindFusion.Diagramming;
using System;
using System.Collections.Generic;
using System.ComponentModel; //nos ayuda con las descripciones que se pueden usar con una clase como al igual que en un propertygrid
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Entidades
    {
        class Entidaes
        {
        }
    }
    
    public class Nodo //nodo o figuras
    {
        public Nodo(int inx)
        {
            indice = inx;
        }
        private int indice;
        public int Indice
        {
            get { return indice; }
        }
        public Nodo(AnchorPattern ancho, Shape shape, string name)
        {
            anchor = ancho;
            figura = shape;
            nombre = name;
        }
        private AnchorPattern anchor;//punto donde se pueden conectar en pos especifica los links (flechas)
        public AnchorPattern Anchor
        {
            get { return anchor; }
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
        public static Type Tipo()
        {
            return new Nodo(0).GetType(); // me devolvera el tipo de onjeto que es en tiempo real. ej: Generador_Diagramas.Nodo
        }
    }
    public class Conector  //conector  o flechas
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
    public class NodoPropiedades
    {
        //agrupar propiedades de campos con sus descripciones para el GridPropiedades                          
        private string _Texto;
        [Description("El texto que se desplega en el nodo...")]//descirpcion de dicha propiedad
        [Category("Propiedades")]//Establece la categoria en que peteneceran
        public string Texto
        {
            get { return _Texto; }
            set { _Texto = value; }
        }

        private Font _Fuente;
        [Description("La fuente Tipografica que contiene el nodo...")]
        [Category("Propiedades")]
        public Font Fuente
        {
            get { return _Fuente; }
            set { _Fuente = value; }
        }
        private Color _Color_Fuente;
        [Description("Sera el color del Texto...")]
        [Category("Propiedades")]
        public Color ColorFuente
        {
            get { return _Color_Fuente; }
            set { _Color_Fuente = value; }
        }
        private Color _Relleno;
        [Description("El color del relleno del nodo...")]
        [Category("Propiedades")]
        public Color Relleno
        {
            get { return _Relleno; }
            set { _Relleno = value; }
        }
        private int _Duracion;
        [Description("Sera la Duracion de dicha Actividad en Dias...")]
        [Category("Tiempo de Actividad")]
        public int Duracion
        {
            get { return _Duracion; }
            set
            {
                _Duracion = value;
                if (_Duracion < 0)
                {
                    _Duracion = 0;
                    throw new Exception("NOSE PUEDE INGRESAR NUMEROS NEGATIVOS...");
                }

            }
        }
        //nota
        //para que funcione  el description y category debe ser asi 
        //[Browsable(bool)]                            // this property should be visible
        //[ReadOnly(false)]                            // this property is for editing
        //[Description("Example Displaying hint 2")]   // sample hint2
        //[Category("Category1")]
        // propfull si no es en es orden no funciona 
    }
}
