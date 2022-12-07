namespace WinFormCaffenio
{
    public partial class FrmPpal : Form
    {
        //def vars
        string[,] prods = new string[10,4];
        int contadorProd = 0;

       // List<Productos> nProductos = new List<Productos>();

        public FrmPpal()
        {
            InitializeComponent();
        }

        private void picBoxRow1Col1Americano_Click(object sender, EventArgs e)
        {
            
            //guardamos en el producto ACTUAL el cafe americano como seleccion
            prods[contadorProd, 0] = Productos.AMERICANO.ToString();
            // abnrimos la form de tamaño
            FrmTamano formaTamano = new FrmTamano();
            formaTamano.Show();
        }

        private void picBoxRow1Col1Americano_MouseHover(object sender, EventArgs e)
        {
            picBoxRow1Col1Americano.BackColor = System.Drawing.Color.Gray;
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {

        }

        private void picBoxRow1Col1Americano_MouseLeave(object sender, EventArgs e)
        {
            picBoxRow1Col1Americano.BackColor = System.Drawing.Color.White;
        }

        private void FrmPpal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //si se presiona ESC salir
            //MessageBox.Show("Se aplastó la tecla " + (int)e.KeyChar+" "+e.KeyChar.ToString());
            if (e.KeyChar == 27)
            {
                //se aplast{o esc
                this.Close();
            }
        }
    }

    //creamos enum de productos
    public enum Productos
    {
        AMERICANO,
        EXPRESSO,
        CAPUCCINO,
        KFREEZE

    }
}