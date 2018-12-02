namespace ProyectoPrograIV
{
    partial class MantenimientoAsociados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dgvMantAsociados = new MetroFramework.Controls.MetroGrid();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarAsociado = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtMantABuscar = new MetroFramework.Controls.MetroTextBox();
            this.txtMantANombreEmpresa = new MetroFramework.Controls.MetroTextBox();
            this.cbxMantAOperacion = new System.Windows.Forms.ComboBox();
            this.DescripcionOperacion = new MetroFramework.Controls.MetroLabel();
            this.btnVolver = new MetroFramework.Controls.MetroButton();
            this.txtMantADireccion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMantAIdentificacion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnModificarA = new MetroFramework.Controls.MetroButton();
            this.btnEliminarA = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantAsociados)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(74, 302);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(114, 19);
            this.metroLabel5.TabIndex = 118;
            this.metroLabel5.Text = "Nombre Empresa";
            // 
            // dgvMantAsociados
            // 
            this.dgvMantAsociados.AllowUserToAddRows = false;
            this.dgvMantAsociados.AllowUserToDeleteRows = false;
            this.dgvMantAsociados.AllowUserToResizeRows = false;
            this.dgvMantAsociados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMantAsociados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMantAsociados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMantAsociados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMantAsociados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMantAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantAsociados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.NombreEmpresa,
            this.Direccion,
            this.Operacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMantAsociados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMantAsociados.EnableHeadersVisualStyles = false;
            this.dgvMantAsociados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvMantAsociados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMantAsociados.Location = new System.Drawing.Point(23, 107);
            this.dgvMantAsociados.Name = "dgvMantAsociados";
            this.dgvMantAsociados.ReadOnly = true;
            this.dgvMantAsociados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMantAsociados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMantAsociados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMantAsociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMantAsociados.Size = new System.Drawing.Size(763, 149);
            this.dgvMantAsociados.TabIndex = 117;
            this.dgvMantAsociados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMantAsociados_CellContentClick);
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Identificacion.DataPropertyName = "Identificacion";
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // NombreEmpresa
            // 
            this.NombreEmpresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreEmpresa.DataPropertyName = "NombreEmpresa";
            this.NombreEmpresa.HeaderText = "Nombre";
            this.NombreEmpresa.Name = "NombreEmpresa";
            this.NombreEmpresa.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Operacion
            // 
            this.Operacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Operacion.DataPropertyName = "DescripcionOperacion";
            this.Operacion.HeaderText = "Operación";
            this.Operacion.Name = "Operacion";
            this.Operacion.ReadOnly = true;
            // 
            // btnBuscarAsociado
            // 
            this.btnBuscarAsociado.Location = new System.Drawing.Point(502, 78);
            this.btnBuscarAsociado.Name = "btnBuscarAsociado";
            this.btnBuscarAsociado.Size = new System.Drawing.Size(102, 23);
            this.btnBuscarAsociado.TabIndex = 115;
            this.btnBuscarAsociado.Text = "Buscar Asociado";
            this.btnBuscarAsociado.UseSelectable = true;
            this.btnBuscarAsociado.Click += new System.EventHandler(this.btnBuscarAsociado_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(206, 78);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(133, 19);
            this.metroLabel9.TabIndex = 114;
            this.metroLabel9.Text = "Insertar identificación";
            // 
            // txtMantABuscar
            // 
            // 
            // 
            // 
            this.txtMantABuscar.CustomButton.Image = null;
            this.txtMantABuscar.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtMantABuscar.CustomButton.Name = "";
            this.txtMantABuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantABuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantABuscar.CustomButton.TabIndex = 1;
            this.txtMantABuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantABuscar.CustomButton.UseSelectable = true;
            this.txtMantABuscar.CustomButton.Visible = false;
            this.txtMantABuscar.Lines = new string[0];
            this.txtMantABuscar.Location = new System.Drawing.Point(345, 78);
            this.txtMantABuscar.MaxLength = 32767;
            this.txtMantABuscar.Name = "txtMantABuscar";
            this.txtMantABuscar.PasswordChar = '\0';
            this.txtMantABuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantABuscar.SelectedText = "";
            this.txtMantABuscar.SelectionLength = 0;
            this.txtMantABuscar.SelectionStart = 0;
            this.txtMantABuscar.ShortcutsEnabled = true;
            this.txtMantABuscar.Size = new System.Drawing.Size(137, 23);
            this.txtMantABuscar.TabIndex = 113;
            this.txtMantABuscar.UseSelectable = true;
            this.txtMantABuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantABuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMantANombreEmpresa
            // 
            // 
            // 
            // 
            this.txtMantANombreEmpresa.CustomButton.Image = null;
            this.txtMantANombreEmpresa.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtMantANombreEmpresa.CustomButton.Name = "";
            this.txtMantANombreEmpresa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantANombreEmpresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantANombreEmpresa.CustomButton.TabIndex = 1;
            this.txtMantANombreEmpresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantANombreEmpresa.CustomButton.UseSelectable = true;
            this.txtMantANombreEmpresa.CustomButton.Visible = false;
            this.txtMantANombreEmpresa.Lines = new string[0];
            this.txtMantANombreEmpresa.Location = new System.Drawing.Point(208, 302);
            this.txtMantANombreEmpresa.MaxLength = 32767;
            this.txtMantANombreEmpresa.Name = "txtMantANombreEmpresa";
            this.txtMantANombreEmpresa.PasswordChar = '\0';
            this.txtMantANombreEmpresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantANombreEmpresa.SelectedText = "";
            this.txtMantANombreEmpresa.SelectionLength = 0;
            this.txtMantANombreEmpresa.SelectionStart = 0;
            this.txtMantANombreEmpresa.ShortcutsEnabled = true;
            this.txtMantANombreEmpresa.Size = new System.Drawing.Size(166, 23);
            this.txtMantANombreEmpresa.TabIndex = 103;
            this.txtMantANombreEmpresa.UseSelectable = true;
            this.txtMantANombreEmpresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantANombreEmpresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxMantAOperacion
            // 
            this.cbxMantAOperacion.FormattingEnabled = true;
            this.cbxMantAOperacion.Location = new System.Drawing.Point(552, 269);
            this.cbxMantAOperacion.Name = "cbxMantAOperacion";
            this.cbxMantAOperacion.Size = new System.Drawing.Size(168, 21);
            this.cbxMantAOperacion.TabIndex = 106;
            // 
            // DescripcionOperacion
            // 
            this.DescripcionOperacion.AutoSize = true;
            this.DescripcionOperacion.Location = new System.Drawing.Point(469, 269);
            this.DescripcionOperacion.Name = "DescripcionOperacion";
            this.DescripcionOperacion.Size = new System.Drawing.Size(71, 19);
            this.DescripcionOperacion.TabIndex = 112;
            this.DescripcionOperacion.Text = "Operación";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(645, 78);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 111;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseSelectable = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtMantADireccion
            // 
            // 
            // 
            // 
            this.txtMantADireccion.CustomButton.Image = null;
            this.txtMantADireccion.CustomButton.Location = new System.Drawing.Point(118, 2);
            this.txtMantADireccion.CustomButton.Name = "";
            this.txtMantADireccion.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtMantADireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantADireccion.CustomButton.TabIndex = 1;
            this.txtMantADireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantADireccion.CustomButton.UseSelectable = true;
            this.txtMantADireccion.CustomButton.Visible = false;
            this.txtMantADireccion.Lines = new string[0];
            this.txtMantADireccion.Location = new System.Drawing.Point(208, 340);
            this.txtMantADireccion.MaxLength = 32767;
            this.txtMantADireccion.Name = "txtMantADireccion";
            this.txtMantADireccion.PasswordChar = '\0';
            this.txtMantADireccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantADireccion.SelectedText = "";
            this.txtMantADireccion.SelectionLength = 0;
            this.txtMantADireccion.SelectionStart = 0;
            this.txtMantADireccion.ShortcutsEnabled = true;
            this.txtMantADireccion.Size = new System.Drawing.Size(166, 50);
            this.txtMantADireccion.TabIndex = 104;
            this.txtMantADireccion.UseSelectable = true;
            this.txtMantADireccion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantADireccion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(125, 340);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 108;
            this.metroLabel2.Text = "Dirección";
            // 
            // txtMantAIdentificacion
            // 
            // 
            // 
            // 
            this.txtMantAIdentificacion.CustomButton.Image = null;
            this.txtMantAIdentificacion.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.txtMantAIdentificacion.CustomButton.Name = "";
            this.txtMantAIdentificacion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantAIdentificacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantAIdentificacion.CustomButton.TabIndex = 1;
            this.txtMantAIdentificacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantAIdentificacion.CustomButton.UseSelectable = true;
            this.txtMantAIdentificacion.CustomButton.Visible = false;
            this.txtMantAIdentificacion.Lines = new string[0];
            this.txtMantAIdentificacion.Location = new System.Drawing.Point(208, 265);
            this.txtMantAIdentificacion.MaxLength = 32767;
            this.txtMantAIdentificacion.Name = "txtMantAIdentificacion";
            this.txtMantAIdentificacion.PasswordChar = '\0';
            this.txtMantAIdentificacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantAIdentificacion.SelectedText = "";
            this.txtMantAIdentificacion.SelectionLength = 0;
            this.txtMantAIdentificacion.SelectionStart = 0;
            this.txtMantAIdentificacion.ShortcutsEnabled = true;
            this.txtMantAIdentificacion.Size = new System.Drawing.Size(166, 23);
            this.txtMantAIdentificacion.TabIndex = 102;
            this.txtMantAIdentificacion.UseSelectable = true;
            this.txtMantAIdentificacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantAIdentificacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(103, 269);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 107;
            this.metroLabel1.Text = "Identificación";
            // 
            // btnModificarA
            // 
            this.btnModificarA.Location = new System.Drawing.Point(552, 302);
            this.btnModificarA.Name = "btnModificarA";
            this.btnModificarA.Size = new System.Drawing.Size(75, 23);
            this.btnModificarA.TabIndex = 119;
            this.btnModificarA.Text = "Modificar";
            this.btnModificarA.UseSelectable = true;
            this.btnModificarA.Click += new System.EventHandler(this.btnModificarA_Click);
            // 
            // btnEliminarA
            // 
            this.btnEliminarA.Location = new System.Drawing.Point(645, 302);
            this.btnEliminarA.Name = "btnEliminarA";
            this.btnEliminarA.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarA.TabIndex = 120;
            this.btnEliminarA.Text = "Eliminar";
            this.btnEliminarA.UseSelectable = true;
            this.btnEliminarA.Click += new System.EventHandler(this.btnEliminarA_Click);
            // 
            // MantenimientoAsociados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.btnEliminarA);
            this.Controls.Add(this.btnModificarA);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dgvMantAsociados);
            this.Controls.Add(this.btnBuscarAsociado);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtMantABuscar);
            this.Controls.Add(this.txtMantANombreEmpresa);
            this.Controls.Add(this.cbxMantAOperacion);
            this.Controls.Add(this.DescripcionOperacion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtMantADireccion);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtMantAIdentificacion);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MantenimientoAsociados";
            this.Text = "MantenimientoAsociados";
            this.Load += new System.EventHandler(this.MantenimientoAsociados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantAsociados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid dgvMantAsociados;
        private MetroFramework.Controls.MetroButton btnBuscarAsociado;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtMantABuscar;
        private MetroFramework.Controls.MetroTextBox txtMantANombreEmpresa;
        private System.Windows.Forms.ComboBox cbxMantAOperacion;
        private MetroFramework.Controls.MetroLabel DescripcionOperacion;
        private MetroFramework.Controls.MetroButton btnVolver;
        private MetroFramework.Controls.MetroTextBox txtMantADireccion;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtMantAIdentificacion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnModificarA;
        private MetroFramework.Controls.MetroButton btnEliminarA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacion;
    }
}