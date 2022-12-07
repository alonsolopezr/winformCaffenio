namespace WinFormCaffenio
{
    partial class FrmTamano
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTamano));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTamanoGrande = new System.Windows.Forms.Label();
            this.picBoxTamanoGrande = new System.Windows.Forms.PictureBox();
            this.lblTamanoMed = new System.Windows.Forms.Label();
            this.picBoxTamanoMediano = new System.Windows.Forms.PictureBox();
            this.lblTamanoChico = new System.Windows.Forms.Label();
            this.picBoxTamanoChico = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTamanoGrande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTamanoMediano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTamanoChico)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTamanoGrande);
            this.panel1.Controls.Add(this.picBoxTamanoGrande);
            this.panel1.Controls.Add(this.lblTamanoMed);
            this.panel1.Controls.Add(this.picBoxTamanoMediano);
            this.panel1.Controls.Add(this.lblTamanoChico);
            this.panel1.Controls.Add(this.picBoxTamanoChico);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 184);
            this.panel1.TabIndex = 0;
            // 
            // lblTamanoGrande
            // 
            this.lblTamanoGrande.AutoSize = true;
            this.lblTamanoGrande.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTamanoGrande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTamanoGrande.Location = new System.Drawing.Point(602, 159);
            this.lblTamanoGrande.Name = "lblTamanoGrande";
            this.lblTamanoGrande.Size = new System.Drawing.Size(63, 21);
            this.lblTamanoGrande.TabIndex = 5;
            this.lblTamanoGrande.Text = "Grande";
            // 
            // picBoxTamanoGrande
            // 
            this.picBoxTamanoGrande.BackColor = System.Drawing.Color.Transparent;
            this.picBoxTamanoGrande.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTamanoGrande.Image")));
            this.picBoxTamanoGrande.Location = new System.Drawing.Point(521, 3);
            this.picBoxTamanoGrande.Name = "picBoxTamanoGrande";
            this.picBoxTamanoGrande.Size = new System.Drawing.Size(228, 153);
            this.picBoxTamanoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTamanoGrande.TabIndex = 4;
            this.picBoxTamanoGrande.TabStop = false;
            // 
            // lblTamanoMed
            // 
            this.lblTamanoMed.AutoSize = true;
            this.lblTamanoMed.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTamanoMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTamanoMed.Location = new System.Drawing.Point(307, 159);
            this.lblTamanoMed.Name = "lblTamanoMed";
            this.lblTamanoMed.Size = new System.Drawing.Size(70, 21);
            this.lblTamanoMed.TabIndex = 3;
            this.lblTamanoMed.Text = "Mediano";
            // 
            // picBoxTamanoMediano
            // 
            this.picBoxTamanoMediano.BackColor = System.Drawing.Color.Transparent;
            this.picBoxTamanoMediano.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTamanoMediano.Image")));
            this.picBoxTamanoMediano.Location = new System.Drawing.Point(233, 29);
            this.picBoxTamanoMediano.Name = "picBoxTamanoMediano";
            this.picBoxTamanoMediano.Size = new System.Drawing.Size(218, 127);
            this.picBoxTamanoMediano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTamanoMediano.TabIndex = 2;
            this.picBoxTamanoMediano.TabStop = false;
            // 
            // lblTamanoChico
            // 
            this.lblTamanoChico.AutoSize = true;
            this.lblTamanoChico.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTamanoChico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTamanoChico.Location = new System.Drawing.Point(66, 159);
            this.lblTamanoChico.Name = "lblTamanoChico";
            this.lblTamanoChico.Size = new System.Drawing.Size(51, 21);
            this.lblTamanoChico.TabIndex = 1;
            this.lblTamanoChico.Text = "Chico";
            // 
            // picBoxTamanoChico
            // 
            this.picBoxTamanoChico.BackColor = System.Drawing.Color.Transparent;
            this.picBoxTamanoChico.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTamanoChico.Image")));
            this.picBoxTamanoChico.Location = new System.Drawing.Point(0, 61);
            this.picBoxTamanoChico.Name = "picBoxTamanoChico";
            this.picBoxTamanoChico.Size = new System.Drawing.Size(182, 95);
            this.picBoxTamanoChico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTamanoChico.TabIndex = 0;
            this.picBoxTamanoChico.TabStop = false;
            this.picBoxTamanoChico.Click += new System.EventHandler(this.picBoxTamanoChico_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atras <-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmTamano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTamano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione el Tamaño que quiera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTamano_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTamanoGrande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTamanoMediano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTamanoChico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblTamanoGrande;
        private PictureBox picBoxTamanoGrande;
        private Label lblTamanoMed;
        private PictureBox picBoxTamanoMediano;
        private Label lblTamanoChico;
        private PictureBox picBoxTamanoChico;
        private Button button1;
    }
}