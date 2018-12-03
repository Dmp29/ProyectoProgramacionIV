namespace ProyectoPrograIV
{
    partial class RegistroPlanesPago
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
            this.btnRegistroPA = new MetroFramework.Controls.MetroButton();
            this.txtIntereses = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtPlazoPA = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMontoPA = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtIdentificacionPA = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnVolver = new MetroFramework.Controls.MetroButton();
            this.dgvPlan = new MetroFramework.Controls.MetroGrid();
            this.Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuota2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPago = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistroPA
            // 
            this.btnRegistroPA.Location = new System.Drawing.Point(458, 118);
            this.btnRegistroPA.Name = "btnRegistroPA";
            this.btnRegistroPA.Size = new System.Drawing.Size(75, 23);
            this.btnRegistroPA.TabIndex = 26;
            this.btnRegistroPA.Text = "Registro";
            this.btnRegistroPA.UseSelectable = true;
            this.btnRegistroPA.Click += new System.EventHandler(this.btnRegistroPA_Click);
            // 
            // txtIntereses
            // 
            // 
            // 
            // 
            this.txtIntereses.CustomButton.Image = null;
            this.txtIntereses.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtIntereses.CustomButton.Name = "";
            this.txtIntereses.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIntereses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIntereses.CustomButton.TabIndex = 1;
            this.txtIntereses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIntereses.CustomButton.UseSelectable = true;
            this.txtIntereses.CustomButton.Visible = false;
            this.txtIntereses.Lines = new string[0];
            this.txtIntereses.Location = new System.Drawing.Point(297, 118);
            this.txtIntereses.MaxLength = 32767;
            this.txtIntereses.Name = "txtIntereses";
            this.txtIntereses.PasswordChar = '\0';
            this.txtIntereses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIntereses.SelectedText = "";
            this.txtIntereses.SelectionLength = 0;
            this.txtIntereses.SelectionStart = 0;
            this.txtIntereses.ShortcutsEnabled = true;
            this.txtIntereses.Size = new System.Drawing.Size(75, 23);
            this.txtIntereses.TabIndex = 25;
            this.txtIntereses.UseSelectable = true;
            this.txtIntereses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIntereses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIntereses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntereses_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(232, 118);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Intereses";
            // 
            // txtPlazoPA
            // 
            // 
            // 
            // 
            this.txtPlazoPA.CustomButton.Image = null;
            this.txtPlazoPA.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtPlazoPA.CustomButton.Name = "";
            this.txtPlazoPA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPlazoPA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPlazoPA.CustomButton.TabIndex = 1;
            this.txtPlazoPA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPlazoPA.CustomButton.UseSelectable = true;
            this.txtPlazoPA.CustomButton.Visible = false;
            this.txtPlazoPA.Lines = new string[0];
            this.txtPlazoPA.Location = new System.Drawing.Point(297, 77);
            this.txtPlazoPA.MaxLength = 32767;
            this.txtPlazoPA.Name = "txtPlazoPA";
            this.txtPlazoPA.PasswordChar = '\0';
            this.txtPlazoPA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlazoPA.SelectedText = "";
            this.txtPlazoPA.SelectionLength = 0;
            this.txtPlazoPA.SelectionStart = 0;
            this.txtPlazoPA.ShortcutsEnabled = true;
            this.txtPlazoPA.Size = new System.Drawing.Size(75, 23);
            this.txtPlazoPA.TabIndex = 23;
            this.txtPlazoPA.UseSelectable = true;
            this.txtPlazoPA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlazoPA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlazoPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlazoPA_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(250, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Plazo";
            // 
            // txtMontoPA
            // 
            // 
            // 
            // 
            this.txtMontoPA.CustomButton.Image = null;
            this.txtMontoPA.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtMontoPA.CustomButton.Name = "";
            this.txtMontoPA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMontoPA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMontoPA.CustomButton.TabIndex = 1;
            this.txtMontoPA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMontoPA.CustomButton.UseSelectable = true;
            this.txtMontoPA.CustomButton.Visible = false;
            this.txtMontoPA.Lines = new string[0];
            this.txtMontoPA.Location = new System.Drawing.Point(132, 118);
            this.txtMontoPA.MaxLength = 32767;
            this.txtMontoPA.Name = "txtMontoPA";
            this.txtMontoPA.PasswordChar = '\0';
            this.txtMontoPA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMontoPA.SelectedText = "";
            this.txtMontoPA.SelectionLength = 0;
            this.txtMontoPA.SelectionStart = 0;
            this.txtMontoPA.ShortcutsEnabled = true;
            this.txtMontoPA.Size = new System.Drawing.Size(75, 23);
            this.txtMontoPA.TabIndex = 21;
            this.txtMontoPA.UseSelectable = true;
            this.txtMontoPA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMontoPA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMontoPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoPA_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 118);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Monto financiado";
            // 
            // txtIdentificacionPA
            // 
            // 
            // 
            // 
            this.txtIdentificacionPA.CustomButton.Image = null;
            this.txtIdentificacionPA.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtIdentificacionPA.CustomButton.Name = "";
            this.txtIdentificacionPA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdentificacionPA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdentificacionPA.CustomButton.TabIndex = 1;
            this.txtIdentificacionPA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdentificacionPA.CustomButton.UseSelectable = true;
            this.txtIdentificacionPA.CustomButton.Visible = false;
            this.txtIdentificacionPA.Lines = new string[0];
            this.txtIdentificacionPA.Location = new System.Drawing.Point(132, 76);
            this.txtIdentificacionPA.MaxLength = 32767;
            this.txtIdentificacionPA.Name = "txtIdentificacionPA";
            this.txtIdentificacionPA.PasswordChar = '\0';
            this.txtIdentificacionPA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdentificacionPA.SelectedText = "";
            this.txtIdentificacionPA.SelectionLength = 0;
            this.txtIdentificacionPA.SelectionStart = 0;
            this.txtIdentificacionPA.ShortcutsEnabled = true;
            this.txtIdentificacionPA.Size = new System.Drawing.Size(75, 23);
            this.txtIdentificacionPA.TabIndex = 19;
            this.txtIdentificacionPA.UseSelectable = true;
            this.txtIdentificacionPA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdentificacionPA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdentificacionPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentificacionPA_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Identificación";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(748, 32);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 50;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseSelectable = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AllowUserToDeleteRows = false;
            this.dgvPlan.AllowUserToResizeRows = false;
            this.dgvPlan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuota,
            this.Cuota2,
            this.Intereses,
            this.Principal,
            this.Saldo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlan.EnableHeadersVisualStyles = false;
            this.dgvPlan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPlan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPlan.Location = new System.Drawing.Point(23, 169);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.ReadOnly = true;
            this.dgvPlan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlan.Size = new System.Drawing.Size(800, 356);
            this.dgvPlan.TabIndex = 51;
            // 
            // Cuota
            // 
            this.Cuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cuota.HeaderText = "Cuota";
            this.Cuota.Name = "Cuota";
            this.Cuota.ReadOnly = true;
            // 
            // Cuota2
            // 
            this.Cuota2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cuota2.HeaderText = "Cuota";
            this.Cuota2.Name = "Cuota2";
            this.Cuota2.ReadOnly = true;
            // 
            // Intereses
            // 
            this.Intereses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Intereses.HeaderText = "Intereses";
            this.Intereses.Name = "Intereses";
            this.Intereses.ReadOnly = true;
            // 
            // Principal
            // 
            this.Principal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Principal.HeaderText = "Principal";
            this.Principal.Name = "Principal";
            this.Principal.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // txtPago
            // 
            // 
            // 
            // 
            this.txtPago.CustomButton.Image = null;
            this.txtPago.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtPago.CustomButton.Name = "";
            this.txtPago.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPago.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPago.CustomButton.TabIndex = 1;
            this.txtPago.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPago.CustomButton.UseSelectable = true;
            this.txtPago.CustomButton.Visible = false;
            this.txtPago.Lines = new string[0];
            this.txtPago.Location = new System.Drawing.Point(458, 76);
            this.txtPago.MaxLength = 32767;
            this.txtPago.Name = "txtPago";
            this.txtPago.PasswordChar = '\0';
            this.txtPago.ReadOnly = true;
            this.txtPago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPago.SelectedText = "";
            this.txtPago.SelectionLength = 0;
            this.txtPago.SelectionStart = 0;
            this.txtPago.ShortcutsEnabled = true;
            this.txtPago.Size = new System.Drawing.Size(75, 23);
            this.txtPago.TabIndex = 52;
            this.txtPago.UseSelectable = true;
            this.txtPago.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPago.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(411, 76);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(39, 19);
            this.metroLabel5.TabIndex = 53;
            this.metroLabel5.Text = "Pago";
            // 
            // RegistroPlanesPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 537);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.dgvPlan);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistroPA);
            this.Controls.Add(this.txtIntereses);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtPlazoPA);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtMontoPA);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtIdentificacionPA);
            this.Controls.Add(this.metroLabel1);
            this.Name = "RegistroPlanesPago";
            this.Text = "Registro de Plan de Pago";
            this.Load += new System.EventHandler(this.RegistroPlanesPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnRegistroPA;
        private MetroFramework.Controls.MetroTextBox txtIntereses;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtPlazoPA;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMontoPA;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtIdentificacionPA;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnVolver;
        private MetroFramework.Controls.MetroGrid dgvPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuota2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private MetroFramework.Controls.MetroTextBox txtPago;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}