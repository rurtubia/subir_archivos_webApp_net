using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string ruta = Server.MapPath("~/imagenes/");

                string ext = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();

                string[] extensiones = { ".jpg", ".gif", ".png" };

                bool valido = false;

                for (int x = 0; x < extensiones.Length; x++)
                {
                    if (extensiones[x].Equals(ext))
                    {
                        valido = true;
                        break;
                    }
                }
                //FileUpload1.PostedFile.

                if (valido)
	            {
		            FileUpload1.SaveAs(ruta + FileUpload1.FileName);
                    Label1.Text = "Archivo subido exitosamente";
	            }
                else
	            {
                    Label1.Text ="Extensión nde archivo no soportado";
	            }
                
            }
            else
            {
                Label1.Text = "Debe seleccionar un archivo";
            }
        }
    }
}