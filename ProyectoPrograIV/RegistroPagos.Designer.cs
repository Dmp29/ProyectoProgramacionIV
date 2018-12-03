namespace ProyectoPrograIV
{
    partial class RegistroPagos
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
            this.btnAplicarPago = new MetroFramework.Controls.MetroButton();
            this.txtXML = new MetroFramework.Controls.MetroTextBox();
            this.btnVolver = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnAplicarPago
            // 
            this.btnAplicarPago.Location = new System.Drawing.Point(166, 114);
            this.btnAplicarPago.Name = "btnAplicarPago";
            this.btnAplicarPago.Size = new System.Drawing.Size(75, 23);
            this.btnAplicarPago.TabIndex = 17;
            this.btnAplicarPago.Text = "Aplicar pago";
            this.btnAplicarPago.UseSelectable = true;
            this.btnAplicarPago.Click += new System.EventHandler(this.btnAplicarPago_Click);
            // 
            // txtXML
            // 
            // 
            // 
            // 
            this.txtXML.CustomButton.Image = null;
            this.txtXML.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtXML.CustomButton.Name = "";
            this.txtXML.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtXML.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtXML.CustomButton.TabIndex = 1;
            this.txtXML.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtXML.CustomButton.UseSelectable = true;
            this.txtXML.CustomButton.Visible = false;
            this.txtXML.Lines = new string[0];
            this.txtXML.Location = new System.Drawing.Point(145, 69);
            this.txtXML.MaxLength = 32767;
            this.txtXML.Name = "txtXML";
            this.txtXML.PasswordChar = '\0';
            this.txtXML.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtXML.SelectedText = "";
            this.txtXML.SelectionLength = 0;
            this.txtXML.SelectionStart = 0;
            this.txtXML.ShortcutsEnabled = true;
            this.txtXML.Size = new System.Drawing.Size(156, 23);
            this.txtXML.TabIndex = 10;
            this.txtXML.UseSelectable = true;
            this.txtXML.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtXML.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(47, 114);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 52;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseSelectable = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(308, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 53;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(61, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Inserte XML";
            // 
            // RegistroPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 191);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAplicarPago);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.metroLabel1);
            this.Name = "RegistroPagos";
            this.Text = "Registro de Pago";
            this.Load += new System.EventHandler(this.RegistroPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAplicarPago;
        private MetroFramework.Controls.MetroTextBox txtXML;
        private MetroFramework.Controls.MetroButton btnVolver;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}