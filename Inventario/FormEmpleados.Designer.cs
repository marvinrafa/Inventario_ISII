namespace Inventario
{
    partial class FormEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblseleccionado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescripcionMaterial = new System.Windows.Forms.Label();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.PictureBox();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(159, 325);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(191, 20);
            this.txtBusqueda.TabIndex = 77;
            this.txtBusqueda.Visible = false;
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.Red;
            this.lblBusqueda.Location = new System.Drawing.Point(19, 327);
            this.lblBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(145, 15);
            this.lblBusqueda.TabIndex = 70;
            this.lblBusqueda.Text = "Ingrese criterio(NOMBRE):";
            this.lblBusqueda.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Click para seleccionar empleado:";
            // 
            // lblseleccionado
            // 
            this.lblseleccionado.AutoSize = true;
            this.lblseleccionado.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseleccionado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblseleccionado.Location = new System.Drawing.Point(479, 329);
            this.lblseleccionado.Name = "lblseleccionado";
            this.lblseleccionado.Size = new System.Drawing.Size(54, 13);
            this.lblseleccionado.TabIndex = 75;
            this.lblseleccionado.Text = "Ninguno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Empleado seleccionado:";
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grpDatos.Controls.Add(this.txtTelefono);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.txtRol);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.txtID);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.lblDescripcionMaterial);
            this.grpDatos.Enabled = false;
            this.grpDatos.Location = new System.Drawing.Point(561, 148);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(308, 232);
            this.grpDatos.TabIndex = 68;
            this.grpDatos.TabStop = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(20, 189);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(117, 20);
            this.txtTelefono.TabIndex = 30;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Telefono:";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(20, 138);
            this.txtRol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(117, 20);
            this.txtRol.TabIndex = 28;
            this.txtRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRol_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 87);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 20);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre completo:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(18, 32);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(119, 20);
            this.txtID.TabIndex = 23;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Puesto en empresa:";
            // 
            // lblDescripcionMaterial
            // 
            this.lblDescripcionMaterial.AutoSize = true;
            this.lblDescripcionMaterial.Location = new System.Drawing.Point(17, 17);
            this.lblDescripcionMaterial.Name = "lblDescripcionMaterial";
            this.lblDescripcionMaterial.Size = new System.Drawing.Size(101, 13);
            this.lblDescripcionMaterial.TabIndex = 7;
            this.lblDescripcionMaterial.Text = "ID(Sugerencia: dui):";
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgEmpleados.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEmpleados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgEmpleados.Location = new System.Drawing.Point(19, 76);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.ReadOnly = true;
            this.dtgEmpleados.RowHeadersWidth = 51;
            this.dtgEmpleados.Size = new System.Drawing.Size(502, 236);
            this.dtgEmpleados.TabIndex = 66;
            this.dtgEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpleados_CellClick);
            this.dtgEmpleados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgEmpleados_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 65;
            this.label1.Text = "EMPLEADOS";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Image = global::Inventario.Properties.Resources.iconfinder_Print_1493286;
            this.btnImprimir.Location = new System.Drawing.Point(801, 73);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(31, 47);
            this.btnImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImprimir.TabIndex = 73;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::Inventario.Properties.Resources.iconfinder_67_111124;
            this.btnBuscar.Location = new System.Drawing.Point(747, 73);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 47);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 72;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::Inventario.Properties.Resources.iconfinder_Streamline_70_185090;
            this.btnEliminar.Location = new System.Drawing.Point(691, 73);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(33, 47);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 71;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = global::Inventario.Properties.Resources.iconfinder_file_documents_15_854123;
            this.btnModificar.Location = new System.Drawing.Point(637, 73);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(32, 47);
            this.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnModificar.TabIndex = 69;
            this.btnModificar.TabStop = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Image = global::Inventario.Properties.Resources.iconfinder_new10_216291;
            this.btnNuevo.Location = new System.Drawing.Point(584, 73);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(27, 47);
            this.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNuevo.TabIndex = 67;
            this.btnNuevo.TabStop = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = global::Inventario.Properties.Resources.iconfinder_floppy_285657;
            this.btnGuardar.Location = new System.Drawing.Point(253, 177);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(49, 45);
            this.btnGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(894, 459);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblseleccionado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.dtgEmpleados);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mantenimiento de empleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblseleccionado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox btnImprimir;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.PictureBox btnModificar;
        private System.Windows.Forms.PictureBox btnNuevo;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescripcionMaterial;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
    }
}