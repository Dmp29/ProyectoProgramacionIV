namespace ProyectoPrograIV
{
    partial class MantenimientoPlanes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.txtMantPago = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtMantIntereses = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMantPlazo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMantMontoFinanciado = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnVolver = new MetroFramework.Controls.MetroButton();
            this.dgvPlanPago = new MetroFramework.Controls.MetroGrid();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoFinanciado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMantBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtIdentificacion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPago)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(564, 458);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtMantPago
            // 
            // 
            // 
            // 
            this.txtMantPago.CustomButton.Image = null;
            this.txtMantPago.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtMantPago.CustomButton.Name = "";
            this.txtMantPago.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantPago.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantPago.CustomButton.TabIndex = 1;
            this.txtMantPago.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantPago.CustomButton.UseSelectable = true;
            this.txtMantPago.CustomButton.Visible = false;
            this.txtMantPago.Lines = new string[0];
            this.txtMantPago.Location = new System.Drawing.Point(454, 458);
            this.txtMantPago.MaxLength = 32767;
            this.txtMantPago.Name = "txtMantPago";
            this.txtMantPago.PasswordChar = '\0';
            this.txtMantPago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantPago.SelectedText = "";
            this.txtMantPago.SelectionLength = 0;
            this.txtMantPago.SelectionStart = 0;
            this.txtMantPago.ShortcutsEnabled = true;
            this.txtMantPago.Size = new System.Drawing.Size(75, 23);
            this.txtMantPago.TabIndex = 25;
            this.txtMantPago.UseSelectable = true;
            this.txtMantPago.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantPago.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMantPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMantPago_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(348, 462);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Pago";
            // 
            // txtMantIntereses
            // 
            // 
            // 
            // 
            this.txtMantIntereses.CustomButton.Image = null;
            this.txtMantIntereses.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtMantIntereses.CustomButton.Name = "";
            this.txtMantIntereses.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantIntereses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantIntereses.CustomButton.TabIndex = 1;
            this.txtMantIntereses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantIntereses.CustomButton.UseSelectable = true;
            this.txtMantIntereses.CustomButton.Visible = false;
            this.txtMantIntereses.Lines = new string[0];
            this.txtMantIntereses.Location = new System.Drawing.Point(454, 411);
            this.txtMantIntereses.MaxLength = 32767;
            this.txtMantIntereses.Name = "txtMantIntereses";
            this.txtMantIntereses.PasswordChar = '\0';
            this.txtMantIntereses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantIntereses.SelectedText = "";
            this.txtMantIntereses.SelectionLength = 0;
            this.txtMantIntereses.SelectionStart = 0;
            this.txtMantIntereses.ShortcutsEnabled = true;
            this.txtMantIntereses.Size = new System.Drawing.Size(75, 23);
            this.txtMantIntereses.TabIndex = 23;
            this.txtMantIntereses.UseSelectable = true;
            this.txtMantIntereses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantIntereses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMantIntereses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMantIntereses_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(348, 411);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Intereses";
            // 
            // txtMantPlazo
            // 
            // 
            // 
            // 
            this.txtMantPlazo.CustomButton.Image = null;
            this.txtMantPlazo.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtMantPlazo.CustomButton.Name = "";
            this.txtMantPlazo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantPlazo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantPlazo.CustomButton.TabIndex = 1;
            this.txtMantPlazo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantPlazo.CustomButton.UseSelectable = true;
            this.txtMantPlazo.CustomButton.Visible = false;
            this.txtMantPlazo.Lines = new string[0];
            this.txtMantPlazo.Location = new System.Drawing.Point(191, 458);
            this.txtMantPlazo.MaxLength = 32767;
            this.txtMantPlazo.Name = "txtMantPlazo";
            this.txtMantPlazo.PasswordChar = '\0';
            this.txtMantPlazo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantPlazo.SelectedText = "";
            this.txtMantPlazo.SelectionLength = 0;
            this.txtMantPlazo.SelectionStart = 0;
            this.txtMantPlazo.ShortcutsEnabled = true;
            this.txtMantPlazo.Size = new System.Drawing.Size(75, 23);
            this.txtMantPlazo.TabIndex = 21;
            this.txtMantPlazo.UseSelectable = true;
            this.txtMantPlazo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantPlazo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMantPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMantPlazo_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(83, 458);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Plazo";
            // 
            // txtMantMontoFinanciado
            // 
            // 
            // 
            // 
            this.txtMantMontoFinanciado.CustomButton.Image = null;
            this.txtMantMontoFinanciado.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtMantMontoFinanciado.CustomButton.Name = "";
            this.txtMantMontoFinanciado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantMontoFinanciado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantMontoFinanciado.CustomButton.TabIndex = 1;
            this.txtMantMontoFinanciado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantMontoFinanciado.CustomButton.UseSelectable = true;
            this.txtMantMontoFinanciado.CustomButton.Visible = false;
            this.txtMantMontoFinanciado.Lines = new string[0];
            this.txtMantMontoFinanciado.Location = new System.Drawing.Point(191, 411);
            this.txtMantMontoFinanciado.MaxLength = 32767;
            this.txtMantMontoFinanciado.Name = "txtMantMontoFinanciado";
            this.txtMantMontoFinanciado.PasswordChar = '\0';
            this.txtMantMontoFinanciado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantMontoFinanciado.SelectedText = "";
            this.txtMantMontoFinanciado.SelectionLength = 0;
            this.txtMantMontoFinanciado.SelectionStart = 0;
            this.txtMantMontoFinanciado.ShortcutsEnabled = true;
            this.txtMantMontoFinanciado.Size = new System.Drawing.Size(75, 23);
            this.txtMantMontoFinanciado.TabIndex = 19;
            this.txtMantMontoFinanciado.UseSelectable = true;
            this.txtMantMontoFinanciado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantMontoFinanciado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMantMontoFinanciado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMantMontoFinanciado_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(70, 411);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Monto Financiado";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(804, 85);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 49;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseSelectable = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvPlanPago
            // 
            this.dgvPlanPago.AllowUserToAddRows = false;
            this.dgvPlanPago.AllowUserToDeleteRows = false;
            this.dgvPlanPago.AllowUserToResizeRows = false;
            this.dgvPlanPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPlanPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlanPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPlanPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPlanPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificacion,
            this.MontoFinanciado,
            this.Plazo,
            this.Intereses,
            this.Pago});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanPago.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPlanPago.EnableHeadersVisualStyles = false;
            this.dgvPlanPago.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPlanPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPlanPago.Location = new System.Drawing.Point(25, 124);
            this.dgvPlanPago.Name = "dgvPlanPago";
            this.dgvPlanPago.ReadOnly = true;
            this.dgvPlanPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPlanPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlanPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlanPago.Size = new System.Drawing.Size(856, 256);
            this.dgvPlanPago.TabIndex = 101;
            this.dgvPlanPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlanPago_CellContentClick);
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Identificacion.DataPropertyName = "Identificacion";
            this.Identificacion.HeaderText = "Identificacion";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // MontoFinanciado
            // 
            this.MontoFinanciado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MontoFinanciado.DataPropertyName = "MontoFinanciado";
            this.MontoFinanciado.HeaderText = "Monto Financiado";
            this.MontoFinanciado.Name = "MontoFinanciado";
            this.MontoFinanciado.ReadOnly = true;
            // 
            // Plazo
            // 
            this.Plazo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Plazo.DataPropertyName = "Plazo";
            this.Plazo.HeaderText = "Plazo";
            this.Plazo.Name = "Plazo";
            this.Plazo.ReadOnly = true;
            // 
            // Intereses
            // 
            this.Intereses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Intereses.DataPropertyName = "Intereses";
            this.Intereses.HeaderText = "Intereses";
            this.Intereses.Name = "Intereses";
            this.Intereses.ReadOnly = true;
            // 
            // Pago
            // 
            this.Pago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pago.DataPropertyName = "Pago";
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            // 
            // txtMantBuscar
            // 
            // 
            // 
            // 
            this.txtMantBuscar.CustomButton.Image = null;
            this.txtMantBuscar.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtMantBuscar.CustomButton.Name = "";
            this.txtMantBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMantBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMantBuscar.CustomButton.TabIndex = 1;
            this.txtMantBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMantBuscar.CustomButton.UseSelectable = true;
            this.txtMantBuscar.CustomButton.Visible = false;
            this.txtMantBuscar.Lines = new string[0];
            this.txtMantBuscar.Location = new System.Drawing.Point(116, 85);
            this.txtMantBuscar.MaxLength = 32767;
            this.txtMantBuscar.Name = "txtMantBuscar";
            this.txtMantBuscar.PasswordChar = '\0';
            this.txtMantBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMantBuscar.SelectedText = "";
            this.txtMantBuscar.SelectionLength = 0;
            this.txtMantBuscar.SelectionStart = 0;
            this.txtMantBuscar.ShortcutsEnabled = true;
            this.txtMantBuscar.Size = new System.Drawing.Size(125, 23);
            this.txtMantBuscar.TabIndex = 103;
            this.txtMantBuscar.UseSelectable = true;
            this.txtMantBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMantBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMantBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMantBuscar_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(25, 85);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 19);
            this.metroLabel5.TabIndex = 102;
            this.metroLabel5.Text = "Identificación";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(670, 458);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 104;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(258, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 105;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdentificacion
            // 
            // 
            // 
            // 
            this.txtIdentificacion.CustomButton.Image = null;
            this.txtIdentificacion.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtIdentificacion.CustomButton.Name = "";
            this.txtIdentificacion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdentificacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdentificacion.CustomButton.TabIndex = 1;
            this.txtIdentificacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdentificacion.CustomButton.UseSelectable = true;
            this.txtIdentificacion.CustomButton.Visible = false;
            this.txtIdentificacion.Lines = new string[0];
            this.txtIdentificacion.Location = new System.Drawing.Point(670, 411);
            this.txtIdentificacion.MaxLength = 32767;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.PasswordChar = '\0';
            this.txtIdentificacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdentificacion.SelectedText = "";
            this.txtIdentificacion.SelectionLength = 0;
            this.txtIdentificacion.SelectionStart = 0;
            this.txtIdentificacion.ShortcutsEnabled = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(75, 23);
            this.txtIdentificacion.TabIndex = 107;
            this.txtIdentificacion.UseSelectable = true;
            this.txtIdentificacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdentificacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacion_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(579, 411);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(85, 19);
            this.metroLabel6.TabIndex = 106;
            this.metroLabel6.Text = "Identificación";
            // 
            // MantenimientoPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 543);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtMantBuscar);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dgvPlanPago);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtMantPago);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtMantIntereses);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtMantPlazo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtMantMontoFinanciado);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MantenimientoPlanes";
            this.Text = "Mantenimiento de Planes de pago";
            this.Load += new System.EventHandler(this.MantenimientoPlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroTextBox txtMantPago;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtMantIntereses;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMantPlazo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtMantMontoFinanciado;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnVolver;
        private MetroFramework.Controls.MetroGrid dgvPlanPago;
        private MetroFramework.Controls.MetroTextBox txtMantBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoFinanciado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private MetroFramework.Controls.MetroTextBox txtIdentificacion;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}