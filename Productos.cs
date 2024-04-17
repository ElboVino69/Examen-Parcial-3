using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_3
{
    class Productos
    {
        static private int _refresco;
        static private int _sabrita;
        static private int _galleta;
        static private int _jabon;
        static private int _cosmetico;

        static private int cantidad;

        static private int cantidadR;
        static private int cantidadS;
        static private int cantidadG;
        static private int cantidadJ;
        static private int cantidadC;

        static private string _nombre;
        static private double _telefono;
        static private int _pago;


        public void AddPago(int pago )
        {
            _pago = pago;
        }
        public void AddTelefono(double telefono)
        {
            _telefono = telefono;
        }
        public void AddNombre(string nombre)
        {
            _nombre = nombre;
        }
        public string ReturnNombre()
        {
            return _nombre;
        }
        public int ReturnPago()
        {
            return _pago;
        }
        public double ReturnTelefono()
        {
            return _telefono;
        }





        public void AddCantidad(int _cantidad)
        {
            cantidad = _cantidad;
        }
        public void AddRefresco(int refresco = 30)
        {
            cantidadR = cantidadR + cantidad;
            _refresco = cantidad * refresco;
        }
        public void AddSabrita(int sabrita = 20)

        {
            cantidadS = cantidadS + cantidad;
            _sabrita = cantidad * sabrita;
        }
        public void AddGalleta(int galleta = 15)
        {
            cantidadG = cantidadG + cantidad;
            _galleta = cantidad * galleta;
        }
        public void AddJabon(int jabon = 45)
        {
            cantidadJ = cantidadJ +cantidad;
            _jabon = cantidad * jabon;
        }
        public void AddCosmetico(int conmetico = 100)
        {
            cantidadC = cantidadC + cantidad;
            _cosmetico = cantidad * _cosmetico;
        }

        public int ReturnRefresco()
        {
            return _refresco;
        }
        public int ReturnSabrita()
        {
            return _sabrita;
        }
        public int ReturnGalleta()
        {
            return _galleta;
        }
        public int ReturnJabon()
        {
            return _jabon;
        }
        public int ReturnCosmetico()
        {
            return _cosmetico;
        }
        public int ReturnCantidad()
        {
            return cantidad;
        }



        public int ReturnCantidadR()
        {
            return cantidadR;
        }
        public int ReturnCantidadS()
        {
            return cantidadS;
        }
        public int ReturnCantidadG()
        {
            return cantidadG;
        }
        public int ReturnCantidadJ()
        {
            return cantidadJ;
        }
        public int ReturnCantidadC()
        {
            return cantidadC;
        }
    }
}
