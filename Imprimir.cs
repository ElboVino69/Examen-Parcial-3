using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Parcial_3
{
    public partial class Imprimir : Form
    {
        Productos objeto = new Productos();
        Operaciones objeto2 = new Operaciones();
        public Imprimir()
        {
            InitializeComponent();
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            objeto.AddNombre(txtnombre.Text);
            objeto.AddTelefono(Convert.ToDouble(txttelefono.Text));
            objeto.AddPago(Convert.ToInt32(txtpago.Text));

            txtlista.Text = "Nombre:" + objeto.ReturnNombre() +
                "\r\n" + "Telefono:" + objeto.ReturnTelefono() + "\r\n"+"Su pedido:" +
                "\r\n" + objeto.ReturnCantidadR() + " refrescos: $" + objeto.ReturnRefresco() +
                "\r\n" + objeto.ReturnCantidadS() + " sabrita: $" + objeto.ReturnSabrita() +
                "\r\n" + objeto.ReturnCantidadG() + " galletas: $" + objeto.ReturnGalleta() +
                "\r\n" + objeto.ReturnCantidadJ() + " jabones: $" + objeto.ReturnJabon() +
                "\r\n" + objeto.ReturnCantidadC() + " cosmeticos: $" + objeto.ReturnCosmetico();
            lblcambio.Text = objeto2.ReturnCambio().ToString();
        }
    }
}
