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
    public class N_Login
    {
        //clase que se comunica con la presentacion final del sistemma se comunica con datos y entidades para que sean utilizadas en el usuario final
        //su funcion es que datos se comunique y que solo se mande a llamar esta en el usuario final o pantalla de salida.
        D_Login data = new D_Login();

        //METODOS QUE SE COMUNICARAN CON LA CAPA PRESENTACION
        public DataTable IniciarSession(E_Login sender)
        {
            return data.IniciarSesion(sender);
        }
        public void CREARUSUARIO(E_Login SENDER)
        {
            data.CREARUSER(SENDER);
        }
        public void Desactivar_Activar_Usuario(int IDUSER, bool ESTADO)
        {
            data.DESACTIVARActivar(IDUSER,ESTADO);
        }
        public List<E_Login> VerDatosCuenta(int iduser)
        {
            return data.verdatos(iduser);
        }
        public void editcontra(E_Login sender)
        {
            data.editarcontrasena(sender);
        }
        public void ActivarCuenta(string correo, bool ESTADO)
        {
            data.EDITARESTADOuser(correo, ESTADO);
        }
    }
}
