using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcessoCatalogo;
using EntidadCatalogo;
using LogicaCatalogo;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;


namespace Remedial1
{
    public partial class index : System.Web.UI.Page
    {
        Logicaremedial bl = new Logicaremedial();
        Stack<string> imagen = new Stack<string>(4);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["bl"] !=null)
            {  
                bl = (Logicaremedial)Session["bl"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtinsercion.Text = bl.InsertarCatalogo(new EntidadCatalogo.InfCar(new EntidadCatalogo.Catalogoremedial()
            {
                Marca = txtmarca.Text,
                Categoria = txtcatalogo.Text
            }));
            Session["bl"] = bl;
               
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string[] arreglo = null;
            arreglo = bl.MostrarC();
            ListBox1.Items.Clear();
            foreach (string z in arreglo)
            {
                ListBox1.Items.Add(z);
            }
            Session["bl"] = bl;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox5.Text = bl.buscarC(txtmarcab.Text,txtcatalogob.Text);
            Session["bl"] = bl;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox6.Text = "";

            if(FileUpload1.HasFiles)
            {
                if(FileUpload1.PostedFiles.Count <= 4)
                {
                    foreach(HttpPostedFile file in FileUpload1.PostedFiles)
                    {
                        imagen.Push( "Imagenes/" + file.FileName);
                        
                        file.SaveAs(Path.Combine(Server.MapPath("~/Imagenes/"),file.FileName));
                    }
                    TextBox6.Text = bl.CambiarN(imagen, TextBox8.Text, TextBox7.Text);
                }   
                else
                {
                    TextBox6.Text = "Maximo son 4";
                }
            }
            else
            {
                TextBox6.Text = "No hay ningun archivo";
            }
            Session["bl"] = bl;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Label10.Text = "";
            Label10.Text = bl.MostrarImagenC(txtmarcaM.Text, txtcategoriaM.Text);
            Session["bl"] = bl;

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            txtinsercion.Text = bl.InsertarCatalogoP(new EntidadCatalogo.InfCar(new EntidadCatalogo.Catalogoremedial()
            {
                Marca = txtmarca.Text,
                Categoria = txtcatalogo.Text
            }));
            Session["bl"] = bl;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox5.Text = bl.Eliminar(txtmarcab.Text, txtcatalogob.Text);
            Session["bl"] = bl;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {

            Label10.Text = "";
            Label10.Text = bl.EliminarPila(txtmarcaM.Text, txtcategoriaM.Text);
            Session["bl"] = bl;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            EntidadCatalogo.Catalogoremedial[] cad = null;
            Image1.ImageUrl = "catalogos.aspx";
            Session["bl"] = bl;

        }
    }
}