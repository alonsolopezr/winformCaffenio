namespace WinFormCaffenio
{
    partial class FrmPpal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPpal));
            this.panelRow1 = new System.Windows.Forms.Panel();
            this.lblRow1_Col1_Americano = new System.Windows.Forms.Label();
            this.picBoxRow1Col1Americano = new System.Windows.Forms.PictureBox();
            this.btnRow1Col1_Kfreeze = new System.Windows.Forms.Button();
            this.btnRow1Col1_Capuccino = new System.Windows.Forms.Button();
            this.panelRow1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRow1Col1Americano)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRow1
            // 
            this.panelRow1.Controls.Add(this.lblRow1_Col1_Americano);
            this.panelRow1.Controls.Add(this.picBoxRow1Col1Americano);
            this.panelRow1.Controls.Add(this.btnRow1Col1_Kfreeze);
            this.panelRow1.Controls.Add(this.btnRow1Col1_Capuccino);
            this.panelRow1.Location = new System.Drawing.Point(12, 12);
            this.panelRow1.Name = "panelRow1";
            this.panelRow1.Size = new System.Drawing.Size(839, 193);
            this.panelRow1.TabIndex = 0;
            // 
            // lblRow1_Col1_Americano
            // 
            this.lblRow1_Col1_Americano.AutoSize = true;
            this.lblRow1_Col1_Americano.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRow1_Col1_Americano.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRow1_Col1_Americano.Location = new System.Drawing.Point(39, 166);
            this.lblRow1_Col1_Americano.Name = "lblRow1_Col1_Americano";
            this.lblRow1_Col1_Americano.Size = new System.Drawing.Size(125, 21);
            this.lblRow1_Col1_Americano.TabIndex = 4;
            this.lblRow1_Col1_Americano.Text = "Café Americano";
            // 
            // picBoxRow1Col1Americano
            // 
            this.picBoxRow1Col1Americano.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRow1Col1Americano.Image")));
            this.picBoxRow1Col1Americano.Location = new System.Drawing.Point(0, 0);
            this.picBoxRow1Col1Americano.Name = "picBoxRow1Col1Americano";
            this.picBoxRow1Col1Americano.Size = new System.Drawing.Size(206, 177);
            this.picBoxRow1Col1Americano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxRow1Col1Americano.TabIndex = 5;
            this.picBoxRow1Col1Americano.TabStop = false;
            this.picBoxRow1Col1Americano.Click += new System.EventHandler(this.picBoxRow1Col1Americano_Click);
            this.picBoxRow1Col1Americano.MouseHover += new System.EventHandler(this.picBoxRow1Col1Americano_MouseHover);
            // 
            // btnRow1Col1_Kfreeze
            // 
            this.btnRow1Col1_Kfreeze.Location = new System.Drawing.Point(630, 6);
            this.btnRow1Col1_Kfreeze.Name = "btnRow1Col1_Kfreeze";
            this.btnRow1Col1_Kfreeze.Size = new System.Drawing.Size(203, 177);
            this.btnRow1Col1_Kfreeze.TabIndex = 3;
            this.btnRow1Col1_Kfreeze.Text = "btnRow1Col1_Kfreeze";
            this.btnRow1Col1_Kfreeze.UseVisualStyleBackColor = true;
            // 
            // btnRow1Col1_Capuccino
            // 
            this.btnRow1Col1_Capuccino.Location = new System.Drawing.Point(421, 6);
            this.btnRow1Col1_Capuccino.Name = "btnRow1Col1_Capuccino";
            this.btnRow1Col1_Capuccino.Size = new System.Drawing.Size(203, 177);
            this.btnRow1Col1_Capuccino.TabIndex = 2;
            this.btnRow1Col1_Capuccino.Text = "btnRow1Col1_Capuccino";
            this.btnRow1Col1_Capuccino.UseVisualStyleBackColor = true;
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.panelRow1);
            this.Name = "FrmPpal";
            this.Text = "FrmPpal";
            this.panelRow1.ResumeLayout(false);
            this.panelRow1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRow1Col1Americano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelRow1;
        private Button btnRow1Col1_Kfreeze;
        private Button btnRow1Col1_Capuccino;
        private Label lblRow1_Col1_Americano;
        private PictureBox picBoxRow1Col1Americano;
    }
}