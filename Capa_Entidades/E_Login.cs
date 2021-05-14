using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    //capa para las entidades o clases que nos ayudaran para traer datos de base de datos o para procesos
    public class E_Login
    {
        public int ID_Usuario { get; set; }
        public string  Correo_Usuario{ get; set; }
        public string Pass { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public bool Estado { get; set; }
    }

}
