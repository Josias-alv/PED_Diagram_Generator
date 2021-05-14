using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Capa_Entidades
{
    public class E_Imagen
    {
        //convierte un byte a img
        public static Image ByteAImg(byte[] array)
        {
            MemoryStream ms = new MemoryStream(array);
            Image devolverImagen = Image.FromStream(ms);
            return devolverImagen;
        }
        //Convierte Imagen a Byte
        public static byte[] ImageToByte(Image imagenIn)
        {
            MemoryStream mem = new MemoryStream();
            imagenIn.Save(mem, ImageFormat.Png);
            return mem.ToArray();
        }
        //mas preubas de imagenes y bytes
        public static Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }
        public static byte[] ArchAbYTE(Stream ARCH)
        {
            using(MemoryStream mem = new MemoryStream())
            {
                ARCH.CopyTo(mem);
                return mem.ToArray();
            }
        }
    }
    public class E_Diagramas //caracteristicas de los diagramas 
    {
        public int Id_Diagrama { get; set; }
        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string archivoJson { get; set; }
        public byte[] ArchivoPNG { get; set; }
        public string Ruta { get; set; }
        public DateTime Fecha { get; set; }
        public bool Status { get; set; }

    }

}
