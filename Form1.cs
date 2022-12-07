namespace WinFormCaffenio
{
    public partial class FrmPpal : Form
    {
        public FrmPpal()
        {
            InitializeComponent();
        }

        private void picBoxRow1Col1Americano_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedir Americano");
        }

        private void picBoxRow1Col1Americano_MouseHover(object sender, EventArgs e)
        {
            picBoxRow1Col1Americano.BackColor = System.Drawing.Color.Gray;
        }
    }
}