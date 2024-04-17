using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_3
{
    class Operaciones
    {
        Productos objeto = new Productos();
        private int cambio = 0;
        public int ReturnCambio()
        {
            cambio = (objeto.ReturnGalleta()) + (objeto.ReturnRefresco()) + (objeto.ReturnSabrita()) + (objeto.ReturnJabon()) + (objeto.ReturnCosmetico());
            cambio = cambio - objeto.ReturnPago();
            return cambio;
        }
        

    }
}
