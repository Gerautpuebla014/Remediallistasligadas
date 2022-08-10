using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadCatalogo;
using AcessoCatalogo;


namespace LogicaCatalogo
{
    public class Logicaremedial
    {
        private Accesoremedial obdal = new Accesoremedial();

        public string InsertarCatalogo(InfCar nuevo)
        {
            return obdal.InsertarC(nuevo);
        }
        public string[] MostrarC()
        {
            return obdal.MostrarCatalogos();
        }

        public string buscarC(string marc,string cate)
        {
            InfCar piedra = null;
            string salida = "";
            piedra = obdal.buscar(marc, cate);
            if (piedra != null)
            {
                salida = "ENCONTRADO el catalogo encontrado: "  + piedra.informacion.MostrarDatos();
                
            }
            else
            {
                salida = "No se encontro el catalogo";
            }
            return salida;
        }

        public string CambiarN(Stack<string> nombre , string marc, string cate)
        {
            return obdal.CambiarNombreImagen(nombre, marc, cate);
        }
        public string MostrarImagenC(string marc,string cate)
        {
            return obdal.MostrarImagenes(marc, cate);
        }
        public string Eliminar(string marc ,string cate)
        {
            return obdal.EliminarCatalogo(marc, cate);
        }
        public string InsertarCatalogoP(InfCar nuevo)
        {
            return obdal.AgregaralInicio(nuevo);
        }
        public string EliminarPila(string marc,string cate)
        {
            return obdal.EliminarImagen(marc, cate);
        }

    }
}
