namespace WinFormCaffenio
{
    public partial class FrmPpal : Form
    {
        //def vars
        public static string[,] prods = new string[10,6];//cols= 0 prod, 1 tamaño, 2 azucar, 3 canela, 4 stevia, 5 leche de coco
        //cafre americano $ ch = 16, m= 20, g= 27
        //extras azucar 4.00, canela 6.00, stevia 10.00, leche coco 14.00
        public static int contadorProd = 0;


       // List<Productos> nProductos = new List<Productos>();

        public FrmPpal()
        {
            InitializeComponent();
        }

        private void picBoxRow1Col1Americano_Click(object sender, EventArgs e)
        {

            //guardamos en el producto ACTUAL el cafe americano como seleccion
            prods[contadorProd, 0] = ((int)Productos.AMERICANO).ToString();
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