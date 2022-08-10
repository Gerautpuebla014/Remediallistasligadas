using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;
using LogicaCatalogo;
using AcessoCatalogo;
using EntidadCatalogo;

namespace Remedial1
{
    public partial class catalogos : System.Web.UI.Page
    {
        Logicaremedial bl = new Logicaremedial();
        protected void Page_Load(object sender, EventArgs e)
        {
            Bitmap imagen1 = new Bitmap(1220, 1080);
            Graphics hoja = Graphics.FromImage(imagen1);
            EntidadCatalogo.Catalogoremedial[] cad = null;
            if (Session["bl"] != null)
            {
                
                Dibuja(hoja, imagen1.Width, imagen1.Height,cad);
                cad = (EntidadCatalogo.Catalogoremedial[])Session["bl"];
            }

        }
        public void Dibuja(Graphics lienzo, int dimx, int dimy, EntidadCatalogo.Catalogoremedial[] cad)
        {

            Pen lap2 = new Pen(Color.DodgerBlue, 3);
            Pen lapiz1 = new Pen(Color.BlueViolet, 3);
            int x1 = 0, y1 = 0;

            x1 = 10;
            y1 = 10;

            int C = 0;
            for (C = 1; C <= 25; C++)
            {
                //Creacion del rectangulo principal
                lienzo.DrawRectangle(lap2, new Rectangle(x1, y1, 200, 70));
                //Creacion del rectangulo lado izquierdo
                lienzo.DrawRectangle(lap2, new Rectangle((x1), (y1), 40, 70));
                //Creacion del rectangulo derecho 
                lienzo.DrawRectangle(lap2, new Rectangle((x1 + 200), (y1), 40, 70));
                lienzo.DrawString(cad[C-1].Categoria, new Font("Arial", 11), new SolidBrush(Color.LimeGreen), x1 + 50, y1);
                lienzo.DrawString(cad[C-1].Marca, new Font("Arial", 11), new SolidBrush(Color.LimeGreen), x1 + 50, y1 + 10);
                if (C % 5 == 0)
                {
                    lienzo.DrawLine(lap2, x1 + 27, y1 + 130, x1 + 27, y1 + 160);
                    lienzo.DrawLine(lap2, x1 + 25, y1 + 160, 280, y1 + 160);
                    lienzo.DrawLine(lap2, 250, 0, 250, y1 + 130);
                    lienzo.DrawLine(lap2, 280, 60, 280, y1 + 160);

                    lienzo.DrawLine(lap2, x1 + 240, 0, 470, 0);
                    lienzo.DrawLine(lap2, x1 + 460, 10, 470, 0);
                    lienzo.DrawLine(lap2, x1 + 270, 60, 290, 60);
                    lienzo.DrawLine(lap2, x1 + 240, y1 + 130, 185, y1 + 130);
                    x1 = 290;
                }
                else
                {
                    y1 = y1 + 130;
                }
            }
        }
    }
}