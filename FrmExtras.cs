using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormCaffenio
{
    public partial class FrmExtras : Form
    {
        double cuenta = 0;
        public FrmExtras()
        {
            InitializeComponent();
        }

        private void lblAzucar_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panelExtrasIzq_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCanela_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmExtras_Load(object sender, EventArgs e)
        {
            //ubicamos la posicion del lbl de total y cantidad
            int xEnForm = this.Size.Width;
            lblTotalCantidad.Location = new Point(xEnForm - 190, 35);
            lblTotal.Location = new Point(xEnForm - 190 - 110, 35);

            //traernos la info de la orden 
            listBoxOrden.Items.Add("Orden");
            //el tipo de CAFE 
            switch (int.Parse(FrmPpal.prods[0, 0]))
            {
                case (int)Productos.AMERICANO:
                    double costo = 0;
                    switch (FrmPpal.prods[0, 1])
                    {
                        case "CH":
                            costo = 16;
                            break;
                        case "M":
                            costo = 20;
                            break;
                        case "G":
                            costo = 27;
                            break;
                    }

                    cuenta += costo;
                    break;
            }
            //
            string nombre = "";
            double prodCosto = 0;
            if (FrmPpal.prods[0, 0] == "0")
            {
                nombre = "AMERICANO";
                //cafre americano $ ch = 16, m= 20, g= 27
                switch (FrmPpal.prods[0, 1])
                {
                    case "CH":
                        prodCosto = 16;
                        break;
                    case "M":
                        prodCosto = 20;
                        break;
                    case "G":
                        prodCosto = 27;
                        break;
                }


            }
            else if (FrmPpal.prods[0, 0] == "1")
            {
                nombre = "EXPRESSO";
            }
            else if (FrmPpal.prods[0, 0] == "2")
            {
                nombre = "CAPUCCINO";
            }
            else if (FrmPpal.prods[0, 0] == "3")
            {
                nombre = "KFREEZE";
            }
            //agregamos la info del primer prod pedido
            listBoxOrden.Items.Add(nombre + " " + FrmPpal.prods[0, 1]+" $"+prodCosto);

            //actualizar el label de TOTAL con el valor de cuenta}
            lblTotalCantidad.Text = cuenta.ToString();
        }

        private void numUpDownAzucar_ValueChanged(object sender, EventArgs e)
        {
            //azucar 4 por porcion
            this.cuenta += (double)( 4 * numUpDownAzucar.Value);
            //se agrega elemento al listo box
            listBoxOrden.Items.Add(numUpDownAzucar.Value + " Porciones de Azucar ($" + 4 * numUpDownAzucar.Value + ")");

            //actualizar el label de TOTAL con el valor de cuenta}
            lblTotalCantidad.Text = cuenta.ToString();
        }

        private void numUpDownCanela_ValueChanged(object sender, EventArgs e)
        {
            //Canela 4 por porcion
            this.cuenta += (double)(6 * numUpDownCanela.Value);
            //se agrega elemento al listo box
            listBoxOrden.Items.Add(numUpDownCanela.Value + " Porciones de Canela ($" + 6 * numUpDownCanela.Value + ")");

            //actualizar el label de TOTAL con el valor de cuenta}
            lblTotalCantidad.Text = cuenta.ToString();
        }

        private void numUpDownStevia_ValueChanged(object sender, EventArgs e)
        {
            //Canela 4 por porcion
            this.cuenta += (double)(10 * numUpDownStevia.Value);
            //se agrega elemento al listo box
            listBoxOrden.Items.Add(numUpDownStevia.Value + " Porciones de stevia ($" + 10 * numUpDownStevia.Value + ")");

            //actualizar el label de TOTAL con el valor de cuenta}
            lblTotalCantidad.Text = cuenta.ToString();
        }

        private void numUpDownLecheCoco_ValueChanged(object sender, EventArgs e)
        {
            //Canela 4 por porcion
            this.cuenta += (double)(14 * numUpDownLecheCoco.Value);
            //se agrega elemento al listo box
            listBoxOrden.Items.Add(numUpDownLecheCoco.Value + " Porciones de stevia ($" + 14 * numUpDownLecheCoco.Value + ")");

            //actualizar el label de TOTAL con el valor de cuenta}
            lblTotalCantidad.Text = cuenta.ToString();
        }
    }
}
