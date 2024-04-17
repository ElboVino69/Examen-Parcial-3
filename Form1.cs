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
    public partial class Form1 : Form
    {

        Productos objeto = new Productos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrefresco_Click(object sender, EventArgs e)
        {
            pcbimagen.Image = Examen_Parcial_3.Properties.Resources.Refresco;
            objeto.AddRefresco();
            txblista.Text = objeto.ReturnCantidadR() + " refrescos: $" + objeto.ReturnRefresco() +
                "\r\n" + objeto.ReturnCantidadS() + " sabrita: $" + objeto.ReturnSabrita() +
                "\r\n" + objeto.ReturnCantidadG() + " galletas: $" + objeto.ReturnGalleta() +
                "\r\n" + objeto.ReturnCantidadJ() + " jabones: $" + objeto.ReturnJabon() +
                "\r\n" + objeto.ReturnCantidadC() + " cosmeticos: $" + objeto.ReturnCosmetico();
        }

        private void btnsabrita_Click(object sender, EventArgs e)
        {
            pcbimagen.Image = Examen_Parcial_3.Properties.Resources.Sabrita;
            objeto.AddSabrita();
            txblista.Text = objeto.ReturnCantidadR() + " refrescos: $" + objeto.ReturnRefresco() +
                "\r\n" + objeto.ReturnCantidadS() + " sabrita: $" + objeto.ReturnSabrita() +
                "\r\n" + objeto.ReturnCantidadG() + " galletas: $" + objeto.ReturnGalleta() +
                "\r\n" + objeto.ReturnCantidadJ() + " jabones: $" + objeto.ReturnJabon() +
                "\r\n" + objeto.ReturnCantidadC() + " cosmeticos: $" + objeto.ReturnCosmetico();
        }

        private void btngalleta_Click(object sender, EventArgs e)
        {
            pcbimagen.Image = Examen_Parcial_3.Properties.Resources.Galleta;
            objeto.AddGalleta();
            txblista.Text = objeto.ReturnCantidadR() + " refrescos: $" + objeto.ReturnRefresco() +
                "\r\n" + objeto.ReturnCantidadS() + " sabrita: $" + objeto.ReturnSabrita() +
                "\r\n" + objeto.ReturnCantidadG() + " galletas: $" + objeto.ReturnGalleta() +
                "\r\n" + objeto.ReturnCantidadJ() + " jabones: $" + objeto.ReturnJabon() +
                "\r\n" + objeto.ReturnCantidadC() + " cosmeticos: $" + objeto.ReturnCosmetico();
        }

        private void btnjabon_Click(object sender, EventArgs e)
        {
            pcbimagen.Image = Examen_Parcial_3.Properties.Resources.Jabon;
            objeto.AddJabon();
            txblista.Text = objeto.ReturnCantidadR() + " refrescos: $" + objeto.ReturnRefresco() +
                "\r\n" + objeto.ReturnCantidadS() + " sabrita: $" + objeto.ReturnSabrita() +
                "\r\n" + objeto.ReturnCantidadG() + " galletas: $" + objeto.ReturnGalleta() +
                "\r\n" + objeto.ReturnCantidadJ() + " jabones: $" + objeto.ReturnJabon() +
                "\r\n" + objeto.ReturnCantidadC() + " cosmeticos: $" + objeto.ReturnCosmetico();
        }

        private void btncosmetico_Click(object sender, EventArgs e)
        {
            pcbimagen.Image = Examen_Parcial_3.Properties.Resources.Cosmeticos;
            objeto.AddCosmetico();
            txblista.Text = objeto.ReturnCantidadR() + " refrescos: $" + objeto.ReturnRefresco() +
                "\r\n" + objeto.ReturnCantidadS() + " sabrita: $" + objeto.ReturnSabrita() +
                "\r\n" + objeto.ReturnCantidadG() + " galletas: $" + objeto.ReturnGalleta() +
                "\r\n" + objeto.ReturnCantidadJ() + " jabones: $" + objeto.ReturnJabon() +
                "\r\n" + objeto.ReturnCantidadC() + " cosmeticos: $" + objeto.ReturnCosmetico();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            objeto.AddCantidad(Convert.ToInt32(txtcantidad.Text));
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Imprimir print = new Imprimir();
            print.Show();
        }
    }
}
