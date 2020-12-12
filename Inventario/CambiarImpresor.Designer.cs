namespace Inventario
{
    partial class CambiarImpresor
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblImpresor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbImpresoras = new System.Windows.Forms.ComboBox();
            this.btnGuardarProducto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Impresor Actual:";
            // 
            // lblImpresor
            // 
            this.lblImpresor.AutoSize = true;
            this.lblImpresor.Location = new System.Drawing.Point(114, 65);
            this.lblImpresor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImpresor.Name = "lblImpresor";
            this.lblImpresor.Size = new System.Drawing.Size(9, 13);
            this.lblImpresor.TabIndex = 1;
            this.lblImpresor.Text = "l";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione Nuevo:";
            // 
            // cmbImpresoras
            // 
            this.cmbImpresoras.FormattingEnabled = true;
            this.cmbImpresoras.Location = new System.Drawing.Point(116, 126);
            this.cmbImpresoras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbImpresoras.Name = "cmbImpresoras";
            this.cmbImpresoras.Size = new System.Drawing.Size(157, 21);
            this.cmbImpresoras.TabIndex = 6;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGuardarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarProducto.Image = global::Inventario.Properties.Resources.iconfinder_floppy_285657;
            this.btnGuardarProducto.Location = new System.Drawing.Point(184, 180);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(35, 43);
            this.btnGuardarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardarProducto.TabIndex = 11;
            this.btnGuardarProducto.TabStop = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Inventario.Properties.Resources.iconfinder_18_Close_106227;
            this.pictureBox1.Location = new System.Drawing.Point(76, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CambiarImpresor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(308, 258);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.cmbImpresoras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblImpresor);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CambiarImpresor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CambiarImpresor";
            this.Load += new System.EventHandler(this.CambiarImpresor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImpresor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbImpresoras;
        private System.Windows.Forms.PictureBox btnGuardarProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}