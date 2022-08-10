using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Design;


namespace EntidadCatalogo
{
    public class Catalogoremedial
    {
        public string Marca { get; set; }
        public string Categoria { get; set; }

        public Stack<string> Imagenes { get; set; }

        public string MostrarDatos()
        {
            return "El catalogo tiene la marca: " + this.Marca + "  de la categoria: " + this.Categoria;
        }
    }
}
