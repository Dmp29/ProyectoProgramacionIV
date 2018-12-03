namespace ProyectoPrograIV
{
    partial class MantenimientoClientes
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
            this.dgvMantClientes = new MetroFramework.Controls.MetroGrid();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnBuscarCliente = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtMantBuscar = new MetroFramework.Controls.MetroTextBox();
            this.txtMantCNombre = new MetroFramework.Controls.MetroTextBox();
            this.cbxMantCGenero = new System.Windows.Forms.ComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnVolver = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.txtMantCApellido2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMantCApellido1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMantCIdentificacion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMantClientes
            // 
            this.dgvMantClientes.AllowUserToAddRows = false;
            this.dgvMantClientes.AllowUserToDeleteRows = false;
            this.dgvMantClientes.AllowUserToResizeRows = false;
            this.dgvMantClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMantClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMantClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMantClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMantClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMantClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.Nombre,
            this.Apellido1,
            this.Apellido2,
            this.Genero});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMantClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMantClientes.EnableHeadersVisualStyles = false;
            this.dgvMantClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvMantClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvMantClientes.Location = new System.Drawing.Point(36, 89);
            this.dgvMantClientes.Name = "dgvMantClientes";
            this.dgvMantClientes.ReadOnly = true;
            this.dgvMantClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMantClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMantClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMantClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMantClientes.Size = new System.Drawing.Size(763, 149);
            this.dgvMantClientes.TabIndex = 100;
            this.dgvMantClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMantClientes_CellContentClick);
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Identificacion.DataPropertyName = "Identificacion";
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido1
            // 
            this.Apellido1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido1.DataPropertyName = "Apellido1";
            this.Apellido1.HeaderText = "Primer Apellido";
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.ReadOnly = true;
            // 
            // Apellido2
            // 
            this.Apellido2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido2.DataPropertyName = "Apellido2";
            this.Apellido2.HeaderText = "Segundo Apellido";
            this.Apellido2.Name = "Apellido2";
            this.Apellido2.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Genero.DataPropertyName = "DescripcionGenero";
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(684, 328);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 99;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(519, 57);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(102, 23);
            this.btnBuscarCliente.TabIndex = 98;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseSelectable = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(223, 57);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(133, 19);
            this.metroLabel9.TabIndex = 97;
            this.metroLabel9.Text = "Insertar identificación";
            // 
            // txtMantBuscar
            // 
            // 
            // 
            // 
            this.txtMantBuscar.CustomButton.Image = null;
            this.txtMantBuscar.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtMantBuscar.CustomButton.Name = "";
            this.txtMantBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantBuscar.CustomButton.TabIndex = 1;
            this.txtMantBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantBuscar.CustomButton.UseSelectable = true;
            this.txtMantBuscar.CustomButton.Visible = false;
            this.txtMantBuscar.Lines = new string[0];
            this.txtMantBuscar.Location = new System.Drawing.Point(362, 57);
            this.txtMantBuscar.MaxLength = 32767;
            this.txtMantBuscar.Name = "txtMantBuscar";
            this.txtMantBuscar.PasswordChar = '\0';
            this.txtMantBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantBuscar.SelectedText = "";
            this.txtMantBuscar.SelectionLength = 0;
            this.txtMantBuscar.SelectionStart = 0;
            this.txtMantBuscar.ShortcutsEnabled = true;
            this.txtMantBuscar.Size = new System.Drawing.Size(137, 23);
            this.txtMantBuscar.TabIndex = 96;
            this.txtMantBuscar.UseSelectable = true;
            this.txtMantBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMantBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMantBuscar_KeyPress);
            // 
            // txtMantCNombre
            // 
            // 
            // 
            // 
            this.txtMantCNombre.CustomButton.Image = null;
            this.txtMantCNombre.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtMantCNombre.CustomButton.Name = "";
            this.txtMantCNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantCNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantCNombre.CustomButton.TabIndex = 1;
            this.txtMantCNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantCNombre.CustomButton.UseSelectable = true;
            this.txtMantCNombre.CustomButton.Visible = false;
            this.txtMantCNombre.Lines = new string[0];
            this.txtMantCNombre.Location = new System.Drawing.Point(225, 285);
            this.txtMantCNombre.MaxLength = 32767;
            this.txtMantCNombre.Name = "txtMantCNombre";
            this.txtMantCNombre.PasswordChar = '\0';
            this.txtMantCNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantCNombre.SelectedText = "";
            this.txtMantCNombre.SelectionLength = 0;
            this.txtMantCNombre.SelectionStart = 0;
            this.txtMantCNombre.ShortcutsEnabled = true;
            this.txtMantCNombre.Size = new System.Drawing.Size(137, 23);
            this.txtMantCNombre.TabIndex = 80;
            this.txtMantCNombre.UseSelectable = true;
            this.txtMantCNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantCNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMantCNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMantCNombre_KeyPress);
            // 
            // cbxMantCGenero
            // 
            this.cbxMantCGenero.FormattingEnabled = true;
            this.cbxMantCGenero.Location = new System.Drawing.Point(622, 285);
            this.cbxMantCGenero.Name = "cbxMantCGenero";
            this.cbxMantCGenero.Size = new System.Drawing.Size(137, 21);
            this.cbxMantCGenero.TabIndex = 84;
            this.cbxMantCGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxMantCGenero_KeyPress);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(562, 285);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(52, 19);
            this.metroLabel7.TabIndex = 94;
            this.metroLabel7.Text = "Género";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(662, 57);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 92;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseSelectable = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(562, 328);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 91;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtMantCApellido2
            // 
            // 
            // 
            // 
            this.txtMantCApellido2.CustomButton.Image = null;
            this.txtMantCApellido2.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtMantCApellido2.CustomButton.Name = "";
            this.txtMantCApellido2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantCApellido2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantCApellido2.CustomButton.TabIndex = 1;
            this.txtMantCApellido2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantCApellido2.CustomButton.UseSelectable = true;
            this.txtMantCApellido2.CustomButton.Visible = false;
            this.txtMantCApellido2.Lines = new string[0];
            this.txtMantCApellido2.Location = new System.Drawing.Point(622, 244);
            this.txtMantCApellido2.MaxLength = 32767;
            this.txtMantCApellido2.Name = "txtMantCApellido2";
            this.txtMantCApellido2.PasswordChar = '\0';
            this.txtMantCApellido2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantCApellido2.SelectedText = "";
            this.txtMantCApellido2.SelectionLength = 0;
            this.txtMantCApellido2.SelectionStart = 0;
            this.txtMantCApellido2.ShortcutsEnabled = true;
            this.txtMantCApellido2.Size = new System.Drawing.Size(137, 23);
            this.txtMantCApellido2.TabIndex = 82;
            this.txtMantCApellido2.UseSelectable = true;
            this.txtMantCApellido2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantCApellido2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMantCApellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMantCApellido2_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(500, 244);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 19);
            this.metroLabel3.TabIndex = 89;
            this.metroLabel3.Text = "Segundo Apellido";
            // 
            // txtMantCApellido1
            // 
            // 
            // 
            // 
            this.txtMantCApellido1.CustomButton.Image = null;
            this.txtMantCApellido1.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtMantCApellido1.CustomButton.Name = "";
            this.txtMantCApellido1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantCApellido1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantCApellido1.CustomButton.TabIndex = 1;
            this.txtMantCApellido1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantCApellido1.CustomButton.UseSelectable = true;
            this.txtMantCApellido1.CustomButton.Visible = false;
            this.txtMantCApellido1.Lines = new string[0];
            this.txtMantCApellido1.Location = new System.Drawing.Point(225, 328);
            this.txtMantCApellido1.MaxLength = 32767;
            this.txtMantCApellido1.Name = "txtMantCApellido1";
            this.txtMantCApellido1.PasswordChar = '\0';
            this.txtMantCApellido1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantCApellido1.SelectedText = "";
            this.txtMantCApellido1.SelectionLength = 0;
            this.txtMantCApellido1.SelectionStart = 0;
            this.txtMantCApellido1.ShortcutsEnabled = true;
            this.txtMantCApellido1.Size = new System.Drawing.Size(137, 23);
            this.txtMantCApellido1.TabIndex = 81;
            this.txtMantCApellido1.UseSelectable = true;
            this.txtMantCApellido1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantCApellido1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMantCApellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMantCApellido1_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(103, 328);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 88;
            this.metroLabel2.Text = "Primer Apellido";
            // 
            // txtMantCIdentificacion
            // 
            // 
            // 
            // 
            this.txtMantCIdentificacion.CustomButton.Image = null;
            this.txtMantCIdentificacion.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtMantCIdentificacion.CustomButton.Name = "";
            this.txtMantCIdentificacion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantCIdentificacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantCIdentificacion.CustomButton.TabIndex = 1;
            this.txtMantCIdentificacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantCIdentificacion.CustomButton.UseSelectable = true;
            this.txtMantCIdentificacion.CustomButton.Visible = false;
            this.txtMantCIdentificacion.Lines = new string[0];
            this.txtMantCIdentificacion.Location = new System.Drawing.Point(225, 244);
            this.txtMantCIdentificacion.MaxLength = 32767;
            this.txtMantCIdentificacion.Name = "txtMantCIdentificacion";
            this.txtMantCIdentificacion.PasswordChar = '\0';
            this.txtMantCIdentificacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantCIdentificacion.SelectedText = "";
            this.txtMantCIdentificacion.SelectionLength = 0;
            this.txtMantCIdentificacion.SelectionStart = 0;
            this.txtMantCIdentificacion.ShortcutsEnabled = true;
            this.txtMantCIdentificacion.Size = new System.Drawing.Size(137, 23);
            this.txtMantCIdentificacion.TabIndex = 79;
            this.txtMantCIdentificacion.UseSelectable = true;
            this.txtMantCIdentificacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantCIdentificacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMantCIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMantCIdentificacion_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(120, 248);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 87;
            this.metroLabel1.Text = "Identificación";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(146, 289);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 101;
            this.metroLabel5.Text = "Nombre";
            // 
            // MantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 390);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dgvMantClientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtMantBuscar);
            this.Controls.Add(this.txtMantCNombre);
            this.Controls.Add(this.cbxMantCGenero);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtMantCApellido2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtMantCApellido1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtMantCIdentificacion);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MantenimientoClientes";
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.MantenimientoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvMantClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnBuscarCliente;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtMantBuscar;
        private MetroFramework.Controls.MetroTextBox txtMantCNombre;
        private System.Windows.Forms.ComboBox cbxMantCGenero;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnVolver;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroTextBox txtMantCApellido2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMantCApellido1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtMantCIdentificacion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}