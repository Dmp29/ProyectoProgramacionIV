namespace ProyectoPrograIV
{
    partial class ConsultaPagos
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
            this.btnVolver = new MetroFramework.Controls.MetroButton();
            this.dgvCargarPago = new MetroFramework.Controls.MetroGrid();
            this.btnCargar = new MetroFramework.Controls.MetroButton();
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.IdAsociado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargarPago)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(702, 425);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseSelectable = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvCargarPago
            // 
            this.dgvCargarPago.AllowUserToAddRows = false;
            this.dgvCargarPago.AllowUserToDeleteRows = false;
            this.dgvCargarPago.AllowUserToResizeRows = false;
            this.dgvCargarPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCargarPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCargarPago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCargarPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargarPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCargarPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargarPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAsociado,
            this.Identificacion,
            this.IdOperacion,
            this.Cuota,
            this.MontoPago,
            this.IndParcial,
            this.Interes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCargarPago.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCargarPago.EnableHeadersVisualStyles = false;
            this.dgvCargarPago.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCargarPago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCargarPago.Location = new System.Drawing.Point(23, 107);
            this.dgvCargarPago.Name = "dgvCargarPago";
            this.dgvCargarPago.ReadOnly = true;
            this.dgvCargarPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargarPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCargarPago.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCargarPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCargarPago.Size = new System.Drawing.Size(763, 304);
            this.dgvCargarPago.TabIndex = 101;
            this.dgvCargarPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMantClientes_CellContentClick);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(224, 63);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 102;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseSelectable = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtBuscar
            // 
            // 
            // 
            // 
            this.txtBuscar.CustomButton.Image = null;
            this.txtBuscar.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtBuscar.CustomButton.Name = "";
            this.txtBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscar.CustomButton.TabIndex = 1;
            this.txtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscar.CustomButton.UseSelectable = true;
            this.txtBuscar.CustomButton.Visible = false;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(23, 63);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(181, 23);
            this.txtBuscar.TabIndex = 103;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // IdAsociado
            // 
            this.IdAsociado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdAsociado.DataPropertyName = "IdAsociado";
            this.IdAsociado.HeaderText = "Asociado";
            this.IdAsociado.Name = "IdAsociado";
            this.IdAsociado.ReadOnly = true;
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Identificacion.DataPropertyName = "Identificacion";
            this.Identificacion.HeaderText = "Identificación";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            // 
            // IdOperacion
            // 
            this.IdOperacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdOperacion.DataPropertyName = "IdOperacion";
            this.IdOperacion.HeaderText = "Operación";
            this.IdOperacion.Name = "IdOperacion";
            this.IdOperacion.ReadOnly = true;
            // 
            // Cuota
            // 
            this.Cuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cuota.DataPropertyName = "Cuota";
            this.Cuota.HeaderText = "Cuota";
            this.Cuota.Name = "Cuota";
            this.Cuota.ReadOnly = true;
            // 
            // MontoPago
            // 
            this.MontoPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MontoPago.DataPropertyName = "MontoPago";
            this.MontoPago.HeaderText = "Monto de Pago";
            this.MontoPago.Name = "MontoPago";
            this.MontoPago.ReadOnly = true;
            // 
            // IndParcial
            // 
            this.IndParcial.DataPropertyName = "IndParcial";
            this.IndParcial.HeaderText = "IndParcial";
            this.IndParcial.Name = "IndParcial";
            this.IndParcial.ReadOnly = true;
            // 
            // Interes
            // 
            this.Interes.DataPropertyName = "Interes";
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            // 
            // ConsultaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvCargarPago);
            this.Controls.Add(this.btnVolver);
            this.Name = "ConsultaPagos";
            this.Text = "Consulta de Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargarPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnVolver;
        private MetroFramework.Controls.MetroGrid dgvCargarPago;
        private MetroFramework.Controls.MetroButton btnCargar;
        private MetroFramework.Controls.MetroTextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAsociado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndParcial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
    }
}