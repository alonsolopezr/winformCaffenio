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
    public partial class FrmTamano : Form
    {
        public FrmTamano()
        {
            InitializeComponent();
        }

        private void FrmTamano_Load(object sender, EventArgs e)
        {

        }

        private void picBoxTamanoChico_Click(object sender, EventArgs e)
        {
            //se seleccion}o el tamaño chico
            FrmPpal.prods[FrmPpal.contadorProd, 1] = "CH";
            //abrimos el de los extras
            FrmExtras frmExtra = new FrmExtras();
            frmExtra.Show();
        }
    }
}
