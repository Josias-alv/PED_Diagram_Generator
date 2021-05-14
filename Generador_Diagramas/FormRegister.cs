using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Generador_Diagramas.Formbases;
using Capa_Negocio;
using Capa_Entidades;
using MySql.Data.MySqlClient;
namespace Generador_Diagramas
{
    public partial class FormRegister : InvocadoBase
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        N_Login NEG = new N_Login();
       
        private void btnregister_Click(object sender, EventArgs e) 
        {
            try
            {
                if (string.IsNullOrEmpty(txtuserregister.Text) || string.IsNullOrEmpty(txtpasregister.Text) || string.IsNullOrEmpty(txtpasconfirm.Text)) //verificamos que no sea nulo
                {
                    FormError.Mensaje("HA OCURRIDO UN ERROR", "NO PUEDE GURDAR DATOS NULOS... !");
                }
                else
                {
                    if (txtpasregister.Text != txtpasconfirm.Text) //que la contrasena sea igual
                    {
                        FormError.Mensaje("HA OCURRIDO UN ERROR", "EL CAMPO (NUEVA CONTRASEÑA) TIENE QUE SER IGUAL AL CAMPO DE (CONFIRMAR NUEVA CONTRASEÑA) POR FAVOR VERIFIQUE !.");
                    }
                    else
                    {
                        if (ValidarEmail(txtuserregister.Text)) //y que nos ingrese un correo valido
                        {
                            E_Login ENTITIES = new E_Login();
                            ENTITIES.Correo_Usuario = txtuserregister.Text.ToLower();
                            ENTITIES.Pass = sha256(txtpasregister.Text);
                            ENTITIES.Estado = true;
                            NEG.CREARUSUARIO(ENTITIES);
                            FormCompletado.Mensaje("TAREA FINALIZADA", "SU USUARIO SE A CREADO EXISTOSAMENTE...");
                            this.Close();
                        }
                        else
                        {
                            FormError.Mensaje("HA OCURRIDO UN ERROR", "EL CORREO DE USUARIO NO ES EN VERDAD UN CORREO VERIFIQUE POR FAVOR...");
                        }

                    }
                }
            }
            catch (MySqlException )
            {
                FormError.Mensaje("HA OCURRIDO UN ERROR", "EL USUARIO YA EXISTE...");
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
    }
}
