using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Design;


namespace EntidadCatalogo
{
    public class InfCar
    {
        public Catalogoremedial informacion = new Catalogoremedial();
        public InfCar siguiente = null;
        public InfCar anterior = null;

        public InfCar(Catalogoremedial obnuevo)
        {
            informacion = obnuevo;
            siguiente = null;
            anterior = null;
        }

    
        
    }
}
