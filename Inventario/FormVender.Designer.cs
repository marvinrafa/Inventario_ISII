namespace Inventario
{
    partial class FormVender
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
            this.label11 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imgConfirmarCliente = new System.Windows.Forms.PictureBox();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgArticulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgProducto = new System.Windows.Forms.DataGridView();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.btnEliminarArticulo = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregarArticulo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfirmarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarArticulo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(481, 47);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 49;
            this.label11.Text = "Artículos:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPrecio.Location = new System.Drawing.Point(36, 64);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 38);
            this.lblPrecio.TabIndex = 48;
            this.lblPrecio.Text = "0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Total a Pagar:";
            // 
            // grpCliente
            // 
            this.grpCliente.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpCliente.Controls.Add(this.dtgCliente);
            this.grpCliente.Controls.Add(this.txtCliente);
            this.grpCliente.Controls.Add(this.label3);
            this.grpCliente.Controls.Add(this.imgConfirmarCliente);
            this.grpCliente.Location = new System.Drawing.Point(42, 87);
            this.grpCliente.Margin = new System.Windows.Forms.Padding(4);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Padding = new System.Windows.Forms.Padding(4);
            this.grpCliente.Size = new System.Drawing.Size(404, 186);
            this.grpCliente.TabIndex = 42;
            this.grpCliente.TabStop = false;
            // 
            // dtgCliente
            // 
            this.dtgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgCliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(21, 72);
            this.dtgCliente.Margin = new System.Windows.Forms.Padding(4);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.RowHeadersWidth = 51;
            this.dtgCliente.Size = new System.Drawing.Size(301, 83);
            this.dtgCliente.TabIndex = 50;
            this.dtgCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCliente_CellDoubleClick);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(21, 42);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(302, 25);
            this.txtCliente.TabIndex = 23;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress_1);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cliente (Nombre)";
            // 
            // imgConfirmarCliente
            // 
            this.imgConfirmarCliente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.imgConfirmarCliente.Image = global::Inventario.Properties.Resources.done;
            this.imgConfirmarCliente.Location = new System.Drawing.Point(329, 72);
            this.imgConfirmarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.imgConfirmarCliente.Name = "imgConfirmarCliente";
            this.imgConfirmarCliente.Size = new System.Drawing.Size(56, 64);
            this.imgConfirmarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgConfirmarCliente.TabIndex = 41;
            this.imgConfirmarCliente.TabStop = false;
            this.imgConfirmarCliente.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(21, 201);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(122, 25);
            this.txtCantidad.TabIndex = 27;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad";
            // 
            // dtgArticulos
            // 
            this.dtgArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgArticulos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArticulos.Location = new System.Drawing.Point(483, 74);
            this.dtgArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dtgArticulos.Name = "dtgArticulos";
            this.dtgArticulos.ReadOnly = true;
            this.dtgArticulos.RowHeadersWidth = 51;
            this.dtgArticulos.Size = new System.Drawing.Size(646, 321);
            this.dtgArticulos.TabIndex = 40;
            this.dtgArticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArticulos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "NUEVA VENTA:";
            // 
            // dtgProducto
            // 
            this.dtgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgProducto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducto.Location = new System.Drawing.Point(21, 72);
            this.dtgProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dtgProducto.Name = "dtgProducto";
            this.dtgProducto.ReadOnly = true;
            this.dtgProducto.RowHeadersWidth = 51;
            this.dtgProducto.Size = new System.Drawing.Size(364, 79);
            this.dtgProducto.TabIndex = 53;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(21, 42);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(302, 25);
            this.txtProducto.TabIndex = 52;
            this.txtProducto.Leave += new System.EventHandler(this.txtProducto_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "Producto (Código)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblCambio);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtCambio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(485, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 183);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recibo final";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(123, 146);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 17);
            this.label15.TabIndex = 60;
            this.label15.Text = "$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(2, 61);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 38);
            this.label14.TabIndex = 59;
            this.label14.Text = "$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Inventario.Properties.Resources.iconfinder_18_Close_106227;
            this.pictureBox1.Location = new System.Drawing.Point(312, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(148, 146);
            this.lblCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(31, 17);
            this.lblCambio.TabIndex = 56;
            this.lblCambio.Text = "0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 55;
            this.label10.Text = "Cambio:";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(22, 140);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(2);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(94, 25);
            this.txtCambio.TabIndex = 54;
            this.txtCambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCambio_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "$Recibido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Cancelar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "Recibo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::Inventario.Properties.Resources.iconfinder_floppy_285657;
            this.btnGuardar.Location = new System.Drawing.Point(233, 61);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(45, 48);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarArticulo.Enabled = false;
            this.btnEliminarArticulo.Image = global::Inventario.Properties.Resources.iconfinder_Streamline_70_185090;
            this.btnEliminarArticulo.Location = new System.Drawing.Point(24, 25);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(30, 46);
            this.btnEliminarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminarArticulo.TabIndex = 44;
            this.btnEliminarArticulo.TabStop = false;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnEliminarArticulo);
            this.groupBox2.Location = new System.Drawing.Point(1046, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(83, 124);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artículo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(6, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 19);
            this.label13.TabIndex = 45;
            this.label13.Text = "Ninguno";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.txtProducto);
            this.groupBox3.Controls.Add(this.btnAgregarArticulo);
            this.groupBox3.Controls.Add(this.dtgProducto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(42, 299);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(404, 262);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarArticulo.Enabled = false;
            this.btnAgregarArticulo.Image = global::Inventario.Properties.Resources.boton_anadir;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(340, 184);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(45, 55);
            this.btnAgregarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregarArticulo.TabIndex = 54;
            this.btnAgregarArticulo.TabStop = false;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 58;
            // 
            // FormVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1189, 663);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.dtgArticulos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormVender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormVender_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgConfirmarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminarArticulo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox btnEliminarArticulo;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgArticulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.DataGridView dtgProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnAgregarArticulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgConfirmarCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}