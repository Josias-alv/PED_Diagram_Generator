using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generador_Diagramas.Formbases
{
    public partial class InvocadoBase : Form // FORM QUE NOS AYUDA A QUE TODOS LUZCAN BIEN DE UNA, CON METODOS PROPIOS
    {
        //form que hereda la mayoria de forms
        public InvocadoBase()
        {
            InitializeComponent();
        }
        public static string sha256(string pass) // algoritmo de incriptacion
        {
            var sha = new SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = sha.ComputeHash(Encoding.UTF8.GetBytes(pass));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2")); //SI FUERA X2 DEVOLVERIA LA ENCRIPTACION EN MAYUSCULAS !!
            }
            return hash.ToString();
        }
        public static DataSet DataTabletoDataset(DataTable dt) //convertir un datatable a dataset
        {
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dt);
            return dataSet;
        }
        //funcion para validar un correo electronico
        public static bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
                // normaliza el dominio del correo
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,RegexOptions.None, TimeSpan.FromMilliseconds(200));//si no se encuentra en ese intervalo

                // extre el dominio y lo verifica
                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    string nombredominio= idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + nombredominio;
                }
            }
            catch (RegexMatchTimeoutException )
            {
                return false;
            }
            catch (ArgumentException )
            {
                return false;
            }
            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$",RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        //convertir una lista a dataset
        public static DataSet ConvertirADatasetLista<T>(IList<T> list)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);
            foreach (var propInfo in elementType.GetProperties())
            {
                t.Columns.Add(propInfo.Name, propInfo.PropertyType);
            }
            foreach (T item in list)
            {
                DataRow row = t.NewRow();
                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null);
                }
                t.Rows.Add(row);
            }
            return ds;
        }
    }
}
