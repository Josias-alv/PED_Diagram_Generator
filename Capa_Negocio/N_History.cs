using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using Capa_Datos;
using System.Data;
namespace Capa_Negocio
{
    public class N_History
    {
        D_History data = new D_History(); //NOS COMUNICAMOS CON LOS DATOS (MYSQL) CON LA CAPA PRESENTACION(GENERADOR_DIAGRAMAS)

        //METODOS QUE SE COMUNICARAN CON LA CAPA PRESENTACION
        public DataTable VerDiagramasTodos(int iduser)
        {
            return data.vertodos(iduser);
        }
        public DataTable VerActODeactDiagrams(int iduser, bool ActOdeact)
        {
            return data.verActivosODesactivados(iduser, ActOdeact);
        }
        public void CrearDiagrama(E_Diagramas sender)
        {
            data.CrearDiagrama(sender);
        }
        public byte[] TraerIMGMYSQL(int iddiagram)
        {
            return data.TraerIMGDiagram(iddiagram);
        }
        public void ActualizarStatus(int idiagram, bool status)
        {
            data.ACTUALIZARESTADO(idiagram, status);
        }
        public void EditarDiagramaMYSQL(E_Diagramas sender)
        {
            data.EditarDiagrama(sender);
        }
        public void EditDiagramConRuta(E_Diagramas sender)
        {
            data.EditarDiagramaConRuta(sender);
        }
    }
}
