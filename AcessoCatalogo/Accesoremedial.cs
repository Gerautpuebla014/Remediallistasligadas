using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadCatalogo;

namespace AcessoCatalogo
{
    public class Accesoremedial
    {
        private InfCar primero = null;
        private InfCar ultimo = null;
        private int cuentacatalogo = 0;
      

        public string InsertarC(InfCar nuevo)
        {
            string salida = "";

            if (primero == null)
            {
                primero = nuevo;
                salida = "Se ha insertado el primer catalogo y   " + "su numero de catalogos es: " + cuentacatalogo;

            }
            else
            {
                ultimo = primero;
                while (ultimo.siguiente != null)
                {
                    ultimo = ultimo.siguiente;     
                }
                ultimo.siguiente = nuevo;
                nuevo.anterior = ultimo;
                salida = "Se ha insertado un nuevo catalogo " + "su numero de catalogos es: " + cuentacatalogo;

            }
            cuentacatalogo++;
            return salida;
        }
        public string CambiarNombreImagen(Stack<string> nombre, string marc, string cate)
        {
            string salida = "";
            InfCar encontrado = null;
            InfCar recorrido = null;
            recorrido = primero;
            encontrado = buscar(marc, cate);
            if (encontrado == null)
            {
                salida = "No se encontro el catalogo";
            }
            else
            {
                encontrado.informacion.Imagenes = nombre;
                salida = "Se obtuvieron las imagenes";
            }
            return salida;



        }

        public string[] MostrarCatalogos()
        {
            string[] resultado = new string[cuentacatalogo];
            InfCar r1 = null;
            int c = 0;
            r1 = primero;
            while(r1 !=null)
            {
                resultado[c] = r1.informacion.MostrarDatos();
                c++;
                r1 = r1.siguiente;
            }
            return resultado;
        }
        public string MostrarImagenes(string marc, string cate)
        {
            string salida = "";
            Stack<string> imagenes = null;
            InfCar encontrado = null;
            InfCar recorrido = null;
            recorrido = primero;
            encontrado = buscar(marc, cate);
            if (encontrado == null)
            {
                salida = "No se encontro ningun catalago";
            }
            else

            {
                if (encontrado.informacion.Imagenes == null)
                {
                    salida = "No hay imagenes";
                }
                else
                {
                    foreach (string img in encontrado.informacion.Imagenes)
                    {
                        salida = salida + "<img src='" + img + "' width='200px' >" +
                            "<br/>";
                    }
                }

            }
            return salida;
        }
        public InfCar buscar(string marca,string cate)
        {
            InfCar r1 = null;
            InfCar piedrita = null;
            r1 = primero;
            while(r1 !=null)
            {
                if(r1.informacion.Marca == marca && r1.informacion.Categoria == cate)
                {
                    piedrita = r1;
                }
                r1 = r1.siguiente;
            }
            return piedrita;
        }
        
        
        public string EliminarCatalogo(string marc,string cate)
        {
            InfCar encontrado = null;
            string salida = "";
            encontrado = buscar(marc, cate);
            InfCar bola = null;
            InfCar boladelante = null;
            bola = encontrado.anterior;
            boladelante = encontrado.siguiente;
            if (encontrado != null)
            {
                if (encontrado == primero)
                {
                    primero = encontrado.siguiente;
                    encontrado.anterior = null;
                    salida = "Se ha eliminado el primer catalogo";
                    
                }
                else if(encontrado.siguiente == null)
                {
                    encontrado.siguiente = bola;
                    bola.siguiente = null;
                    bola = encontrado.anterior.anterior ;
                    salida = "Se ha eliminado el ultimo catalogo";
                }
                else
                {
                    
                    bola.siguiente = boladelante;
                    boladelante.anterior = bola;
                    bola = null;  
                    boladelante = null;
                    salida = "Se ha eliminado el catalago";
                }
                
            }
            else
            {
                salida = "No se encontro el elemento que quiere eliminar";
            }
            cuentacatalogo--;
            return salida;
        }
        public string EliminarImagen(string marc, string cate)
        {
            string salida = "";
            Stack<string> imagenes = null;
            InfCar encontrado = null;
            InfCar recorrido = null;
            recorrido = primero;
            encontrado = buscar(marc, cate);
            if (encontrado == null)
            {
                salida = "No se encontro ningun catalago";
            }
            else

            {
                if (encontrado.informacion.Imagenes != null)
                {
                    encontrado.informacion.Imagenes.Pop();
                    salida = "Se ha eliminado la imagen cima";
                }
                else
                {
                    salida = "No existen imagenes";


                }

            }
            return salida;

        }
        public string AgregaralInicio(InfCar nuevo)
        {
            string salida = "";
            InfCar cabeza = null;
            cabeza = primero;
            if (nuevo != null)
            {
                
                while (nuevo.anterior != null)
                {
                    nuevo = cabeza.anterior;
                    cabeza = nuevo.siguiente;

                }
                nuevo.anterior = null;
                salida = "Se ha insertado un nuevo catalogo al inicio  " ;
            }

            else
            {
                nuevo = cabeza;
                salida = "Se inserto el primer catalogo" + "su numero de catalogos es: " + cuentacatalogo;
               
            }
            cuentacatalogo++;
            return salida;



        }





    }
    
}
